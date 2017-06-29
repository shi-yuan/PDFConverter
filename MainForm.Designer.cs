namespace PDFConverter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode1 = new DevExpress.XtraEditors.BreadCrumbNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.comboBoxEdit_operation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.breadCrumbEdit_output = new DevExpress.XtraEditors.BreadCrumbEdit();
            this.images = new DevExpress.Utils.ImageCollection(this.components);
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataSet = new PDFConverter.dataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_index = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_operation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadCrumbEdit_output.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.images)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.comboBoxEdit_operation);
            this.layoutControl1.Controls.Add(this.breadCrumbEdit_output);
            this.layoutControl1.Controls.Add(this.btn_add);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(798, 206, 360, 435);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(641, 459);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // comboBoxEdit_operation
            // 
            this.comboBoxEdit_operation.EditValue = "";
            this.comboBoxEdit_operation.Location = new System.Drawing.Point(84, 12);
            this.comboBoxEdit_operation.Name = "comboBoxEdit_operation";
            this.comboBoxEdit_operation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_operation.Properties.NullText = "请选择";
            this.comboBoxEdit_operation.Properties.NullValuePrompt = "请选择";
            this.comboBoxEdit_operation.Properties.NullValuePromptShowForEmptyValue = true;
            this.comboBoxEdit_operation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit_operation.Size = new System.Drawing.Size(545, 20);
            this.comboBoxEdit_operation.StyleController = this.layoutControl1;
            this.comboBoxEdit_operation.TabIndex = 13;
            // 
            // breadCrumbEdit_output
            // 
            this.breadCrumbEdit_output.Location = new System.Drawing.Point(84, 36);
            this.breadCrumbEdit_output.Name = "breadCrumbEdit_output";
            this.breadCrumbEdit_output.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.breadCrumbEdit_output.Properties.ImageIndex = 0;
            this.breadCrumbEdit_output.Properties.Images = this.images;
            breadCrumbNode1.Caption = "Root";
            breadCrumbNode1.Value = "Root";
            this.breadCrumbEdit_output.Properties.Nodes.AddRange(new DevExpress.XtraEditors.BreadCrumbNode[] {
            breadCrumbNode1});
            this.breadCrumbEdit_output.Properties.RootImageIndex = 0;
            this.breadCrumbEdit_output.Properties.RootGlyphClick += new System.EventHandler(this.breadCrumbEdit_output_Properties_RootGlyphClick);
            this.breadCrumbEdit_output.Properties.QueryChildNodes += new DevExpress.XtraEditors.BreadCrumbQueryChildNodesEventHandler(this.breadCrumbEdit_output_Properties_QueryChildNodes);
            this.breadCrumbEdit_output.Properties.ValidatePath += new DevExpress.XtraEditors.BreadCrumbValidatePathEventHandler(this.breadCrumbEdit_output_Properties_ValidatePath);
            this.breadCrumbEdit_output.Properties.NewNodeAdding += new DevExpress.XtraEditors.BreadCrumbNewNodeAddingEventHandler(this.breadCrumbEdit_output_Properties_NewNodeAdding);
            this.breadCrumbEdit_output.Size = new System.Drawing.Size(545, 22);
            this.breadCrumbEdit_output.StyleController = this.layoutControl1;
            this.breadCrumbEdit_output.TabIndex = 12;
            // 
            // images
            // 
            this.images.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("images.ImageStream")));
            this.images.InsertGalleryImage("open_16x16.png", "images/actions/open_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/open_16x16.png"), 0);
            this.images.Images.SetKeyName(0, "open_16x16.png");
            // 
            // btn_add
            // 
            this.btn_add.Appearance.Options.UseTextOptions = true;
            this.btn_add.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageIndex = 0;
            this.btn_add.Location = new System.Drawing.Point(12, 62);
            this.btn_add.MaximumSize = new System.Drawing.Size(100, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 38);
            this.btn_add.StyleController = this.layoutControl1;
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "添加文件";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataMember = "FileDataTable";
            this.gridControl1.DataSource = this.dataSet;
            this.gridControl1.Location = new System.Drawing.Point(12, 104);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(617, 343);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "dataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_index,
            this.gridColumn_name,
            this.gridColumn_status});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // gridColumn_index
            // 
            this.gridColumn_index.Caption = "编号";
            this.gridColumn_index.FieldName = "Id";
            this.gridColumn_index.Name = "gridColumn_index";
            this.gridColumn_index.Visible = true;
            this.gridColumn_index.VisibleIndex = 0;
            this.gridColumn_index.Width = 52;
            // 
            // gridColumn_name
            // 
            this.gridColumn_name.Caption = "文件名称";
            this.gridColumn_name.FieldName = "Name";
            this.gridColumn_name.Name = "gridColumn_name";
            this.gridColumn_name.Visible = true;
            this.gridColumn_name.VisibleIndex = 1;
            this.gridColumn_name.Width = 186;
            // 
            // gridColumn_status
            // 
            this.gridColumn_status.Caption = "状态";
            this.gridColumn_status.FieldName = "Status";
            this.gridColumn_status.Name = "gridColumn_status";
            this.gridColumn_status.Visible = true;
            this.gridColumn_status.VisibleIndex = 2;
            this.gridColumn_status.Width = 186;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(641, 459);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(621, 347);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btn_add;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(98, 42);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(98, 50);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(523, 42);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.breadCrumbEdit_output;
            this.layoutControlItem5.CustomizationFormText = "输出目录";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(621, 26);
            this.layoutControlItem5.Text = "输出目录";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(69, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.comboBoxEdit_operation;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(621, 24);
            this.layoutControlItem1.Text = "PDF转换操作";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(69, 14);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 459);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF转换平台";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_operation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadCrumbEdit_output.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.images)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_index;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_name;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_status;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private dataSet dataSet;
        private DevExpress.XtraEditors.BreadCrumbEdit breadCrumbEdit_output;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.Utils.ImageCollection images;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_operation;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}