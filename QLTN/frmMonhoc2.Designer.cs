namespace QLTN
{
    partial class frmMonhoc2
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.ciThem = new DevExpress.XtraBars.BarCheckItem();
            this.ciSua = new DevExpress.XtraBars.BarCheckItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLammoi = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtMAMH = new System.Windows.Forms.TextBox();
            this.txtTENMH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grMonhoc = new System.Windows.Forms.GroupBox();
            this.lbAlert = new System.Windows.Forms.Label();
            this.lbTENMH = new System.Windows.Forms.Label();
            this.lbMAMH = new System.Windows.Forms.Label();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.qLTN_CS1_DataSet = new QLTN.QLTN_CS1_DataSet();
            this.bds_monhoc = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new QLTN.QLTN_CS1_DataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new QLTN.QLTN_CS1_DataSetTableAdapters.TableAdapterManager();
            this.mONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            this.grMonhoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTN_CS1_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_monhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ciThem,
            this.ciSua,
            this.btnXoa,
            this.btnLammoi});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 17;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(57, 209);
            this.bar2.FloatSize = new System.Drawing.Size(213, 31);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ciThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.ciSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLammoi),
            new DevExpress.XtraBars.LinkPersistInfo(null)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // ciThem
            // 
            this.ciThem.Caption = "Thêm";
            this.ciThem.Id = 11;
            this.ciThem.Name = "ciThem";
            this.ciThem.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.ciThem_CheckedChanged);
            // 
            // ciSua
            // 
            this.ciSua.Caption = "Sửa";
            this.ciSua.Id = 13;
            this.ciSua.Name = "ciSua";
            this.ciSua.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.ciSua_CheckedChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 14;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Caption = "Làm mới";
            this.btnLammoi.Id = 15;
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLammoi_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1059, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 512);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1059, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 490);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1059, 22);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 490);
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(170, 131);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(125, 27);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMAMH
            // 
            this.txtMAMH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMAMH.Location = new System.Drawing.Point(122, 61);
            this.txtMAMH.MaxLength = 5;
            this.txtMAMH.Name = "txtMAMH";
            this.txtMAMH.Size = new System.Drawing.Size(295, 22);
            this.txtMAMH.TabIndex = 6;
            // 
            // txtTENMH
            // 
            this.txtTENMH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTENMH.Location = new System.Drawing.Point(122, 103);
            this.txtTENMH.MaxLength = 40;
            this.txtTENMH.Name = "txtTENMH";
            this.txtTENMH.Size = new System.Drawing.Size(295, 22);
            this.txtTENMH.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã mô học :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên môn học :";
            // 
            // grMonhoc
            // 
            this.grMonhoc.Controls.Add(this.lbAlert);
            this.grMonhoc.Controls.Add(this.lbTENMH);
            this.grMonhoc.Controls.Add(this.lbMAMH);
            this.grMonhoc.Controls.Add(this.txtMAMH);
            this.grMonhoc.Controls.Add(this.label2);
            this.grMonhoc.Controls.Add(this.btnLuu);
            this.grMonhoc.Controls.Add(this.label1);
            this.grMonhoc.Controls.Add(this.txtTENMH);
            this.grMonhoc.Enabled = false;
            this.grMonhoc.Location = new System.Drawing.Point(338, 312);
            this.grMonhoc.Name = "grMonhoc";
            this.grMonhoc.Size = new System.Drawing.Size(472, 180);
            this.grMonhoc.TabIndex = 10;
            this.grMonhoc.TabStop = false;
            this.grMonhoc.Text = "Môn học";
            // 
            // lbAlert
            // 
            this.lbAlert.AutoSize = true;
            this.lbAlert.ForeColor = System.Drawing.Color.Red;
            this.lbAlert.Location = new System.Drawing.Point(119, 19);
            this.lbAlert.Name = "lbAlert";
            this.lbAlert.Size = new System.Drawing.Size(0, 15);
            this.lbAlert.TabIndex = 12;
            // 
            // lbTENMH
            // 
            this.lbTENMH.AutoSize = true;
            this.lbTENMH.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbTENMH.Location = new System.Drawing.Point(119, 86);
            this.lbTENMH.Name = "lbTENMH";
            this.lbTENMH.Size = new System.Drawing.Size(172, 15);
            this.lbTENMH.TabIndex = 11;
            this.lbTENMH.Text = "Nhập tên môn học có 1-40 kí tự";
            // 
            // lbMAMH
            // 
            this.lbMAMH.AutoSize = true;
            this.lbMAMH.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbMAMH.Location = new System.Drawing.Point(119, 43);
            this.lbMAMH.Name = "lbMAMH";
            this.lbMAMH.Size = new System.Drawing.Size(167, 15);
            this.lbMAMH.TabIndex = 10;
            this.lbMAMH.Text = "Nhập mã môn học có  1-5 kí tự";
            // 
            // qLTN_CS1_DataSet
            // 
            this.qLTN_CS1_DataSet.DataSetName = "QLTN_CS1_DataSet";
            this.qLTN_CS1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_monhoc
            // 
            this.bds_monhoc.DataMember = "MONHOC";
            this.bds_monhoc.DataSource = this.qLTN_CS1_DataSet;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLTN.QLTN_CS1_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCGridControl
            // 
            this.mONHOCGridControl.DataSource = this.bds_monhoc;
            this.mONHOCGridControl.Location = new System.Drawing.Point(0, 28);
            this.mONHOCGridControl.MainView = this.gridView1;
            this.mONHOCGridControl.MenuManager = this.barManager1;
            this.mONHOCGridControl.Name = "mONHOCGridControl";
            this.mONHOCGridControl.Size = new System.Drawing.Size(810, 220);
            this.mONHOCGridControl.TabIndex = 15;
            this.mONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAMH,
            this.TENMH});
            this.gridView1.GridControl = this.mONHOCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // MAMH
            // 
            this.MAMH.FieldName = "MAMH";
            this.MAMH.Name = "MAMH";
            this.MAMH.Visible = true;
            this.MAMH.VisibleIndex = 0;
            // 
            // TENMH
            // 
            this.TENMH.FieldName = "TENMH";
            this.TENMH.Name = "TENMH";
            this.TENMH.Visible = true;
            this.TENMH.VisibleIndex = 1;
            // 
            // frmMonhoc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 512);
            this.Controls.Add(this.mONHOCGridControl);
            this.Controls.Add(this.grMonhoc);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMonhoc2";
            this.Text = "frmMonhoc2";
            this.Load += new System.EventHandler(this.frmMonhoc2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            this.grMonhoc.ResumeLayout(false);
            this.grMonhoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTN_CS1_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_monhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTENMH;
        private System.Windows.Forms.TextBox txtMAMH;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.GroupBox grMonhoc;
        private DevExpress.XtraBars.BarCheckItem ciThem;
        private DevExpress.XtraBars.BarCheckItem ciSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLammoi;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private System.Windows.Forms.Label lbTENMH;
        private System.Windows.Forms.Label lbMAMH;
        private System.Windows.Forms.Label lbAlert;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource bds_monhoc;
        private QLTN_CS1_DataSet qLTN_CS1_DataSet;
        private QLTN_CS1_DataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private QLTN_CS1_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl mONHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MAMH;
        private DevExpress.XtraGrid.Columns.GridColumn TENMH;
    }
}