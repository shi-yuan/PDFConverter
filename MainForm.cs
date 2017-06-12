using Aspose.Pdf;
using Aspose.Pdf.Devices;
using DevExpress.Utils.Helpers;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFConverter
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitValues();
        }

        void InitValues()
        {
            //
            var Items = comboBoxEdit_operation.Properties.Items;
            Items.BeginUpdate();
            Items.AddRange(new object[]{
                "PDF转图片"
            });
            Items.EndUpdate();

            // 输出目录
            breadCrumbEdit_output.Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            foreach (DriveInfo driveInfo in FileSystemHelper.GetFixedDrives())
            {
                breadCrumbEdit_output.Properties.History.Add(new BreadCrumbHistoryItem(driveInfo.RootDirectory.ToString()));
            }
        }

        #region 输出目录事件
        private void breadCrumbEdit_output_Properties_NewNodeAdding(object sender, BreadCrumbNewNodeAddingEventArgs e)
        {
            e.Node.PopulateOnDemand = true;
        }

        private void breadCrumbEdit_output_Properties_QueryChildNodes(object sender, BreadCrumbQueryChildNodesEventArgs e)
        {
            if (e.Node.Caption == "Root")
            {
                InitBreadCrumbRootNode(e.Node);
                return;
            }
            if (e.Node.Caption == "Computer")
            {
                InitBreadCrumbComputerNode(e.Node);
                return;
            }
            string dir = e.Node.Path;
            if (!FileSystemHelper.IsDirExists(dir))
                return;
            string[] subDirs = FileSystemHelper.GetSubFolders(dir);
            for (int i = 0; i < subDirs.Length; i++)
            {
                e.Node.ChildNodes.Add(CreateNode(subDirs[i]));
            }
        }

        void InitBreadCrumbRootNode(BreadCrumbNode node)
        {
            node.ChildNodes.Add(new BreadCrumbNode("Desktop", Environment.GetFolderPath(Environment.SpecialFolder.Desktop)));
            node.ChildNodes.Add(new BreadCrumbNode("Documents", Environment.GetFolderPath(Environment.SpecialFolder.Recent)));
            node.ChildNodes.Add(new BreadCrumbNode("Music", Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)));
            node.ChildNodes.Add(new BreadCrumbNode("Pictures", Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)));
            node.ChildNodes.Add(new BreadCrumbNode("Video", Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)));
            node.ChildNodes.Add(new BreadCrumbNode("Program Files", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)));
            node.ChildNodes.Add(new BreadCrumbNode("Windows", Environment.GetFolderPath(Environment.SpecialFolder.Windows)));
        }
        void InitBreadCrumbComputerNode(BreadCrumbNode node)
        {
            foreach (DriveInfo driveInfo in FileSystemHelper.GetFixedDrives())
            {
                node.ChildNodes.Add(new BreadCrumbNode(driveInfo.Name, driveInfo.RootDirectory));
            }
        }
        BreadCrumbNode CreateNode(string path)
        {
            string folderName = FileSystemHelper.GetDirName(path);
            return new BreadCrumbNode(folderName, folderName, true);
        }

        private void breadCrumbEdit_output_Properties_RootGlyphClick(object sender, EventArgs e)
        {
            breadCrumbEdit_output.Properties.BreadCrumbMode = BreadCrumbMode.Edit;
            breadCrumbEdit_output.SelectAll();
        }

        private void breadCrumbEdit_output_Properties_ValidatePath(object sender, BreadCrumbValidatePathEventArgs e)
        {
            if (!FileSystemHelper.IsDirExists(e.Path))
            {
                e.ValidationResult = BreadCrumbValidatePathResult.Cancel;
                return;
            }
            e.ValidationResult = BreadCrumbValidatePathResult.CreateNodes;
        }

        #endregion

        /// <summary>
        /// 添加文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
            string[] names = null;
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "PDF (*.pdf)|*.pdf";
                dlg.Multiselect = true;
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    names = dlg.FileNames;
                }
            }
            if (names == null || names.Length < 1) return;

            var dt = dataSet.FileDataTable;
            dataSet.FileDataTableRow row;

            dt.BeginLoadData();
            dt.Clear();
            for (int i = 0, len = names.Length; i < len; ++i)
            {
                row = dt.NewFileDataTableRow();
                row.Id = i + 1;
                row.Name = names[i];
                row.Status = "等待处理";
                dt.AddFileDataTableRow(row);
            }
            dt.EndLoadData();

            // 开始转换
            Task.Run(() =>
            {
                Parallel.ForEach(dt.AsEnumerable(), new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount }, item =>
                {
                    Invoke(new Action(() =>
                    {
                        item.SetField(dt.StatusColumn, "正在处理");
                    }));
                    try
                    {
                        Pdf2Image(item.Name);
                    }
                    catch (Exception)
                    {
                        Invoke(new Action(() =>
                        {
                            item.SetField(dt.StatusColumn, "处理失败");
                        }));
                    }
                    finally
                    {
                        Invoke(new Action(() =>
                        {
                            item.SetField(dt.StatusColumn, "处理成功");
                        }));
                    }
                });
            });
        }

        void Pdf2Image(string filePath)
        {
            var fileName = Path.GetFileNameWithoutExtension(filePath);
            var path = Path.Combine(breadCrumbEdit_output.Path, fileName);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            using (var pdfDocument = new Document(filePath))
            {
                var resolution = new Resolution(300);
                var jpegDeviceLarge = new JpegDevice(resolution, 100);
                PageCollection pc = pdfDocument.Pages;
                for (int i = 1, count = pc.Count, len = count.ToString().Length; i <= count; ++i)
                {
                    jpegDeviceLarge.Process(pc[i], Path.Combine(path, string.Format("{0}_{1}.jpg", fileName, i.ToString().PadLeft(len, '0'))));
                }
            }
        }
    }
}
