namespace QLTN
{
    partial class frmMonhoc
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbKetqua = new System.Windows.Forms.ToolStripStatusLabel();
            this.qLTN_CS1_DataSet = new QLTN.QLTN_CS1_DataSet();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new QLTN.QLTN_CS1_DataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new QLTN.QLTN_CS1_DataSetTableAdapters.TableAdapterManager();
            this.mONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mAMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLTN_CS1_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbKetqua});
            this.statusStrip1.Location = new System.Drawing.Point(0, 367);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(825, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbKetqua
            // 
            this.lbKetqua.Name = "lbKetqua";
            this.lbKetqua.Size = new System.Drawing.Size(0, 17);
            // 
            // qLTN_CS1_DataSet
            // 
            this.qLTN_CS1_DataSet.DataSetName = "QLTN_CS1_DataSet";
            this.qLTN_CS1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLTN_CS1_DataSet;
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
            this.mONHOCGridControl.DataSource = this.mONHOCBindingSource;
            this.mONHOCGridControl.Location = new System.Drawing.Point(0, 24);
            this.mONHOCGridControl.MainView = this.gridView1;
            this.mONHOCGridControl.Name = "mONHOCGridControl";
            this.mONHOCGridControl.Size = new System.Drawing.Size(805, 220);
            this.mONHOCGridControl.TabIndex = 6;
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
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(265, 282);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(62, 19);
            mAMHLabel.TabIndex = 6;
            mAMHLabel.Text = "MAMH:";
            // 
            // mAMHTextEdit
            // 
            this.mAMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "MAMH", true));
            this.mAMHTextEdit.Location = new System.Drawing.Point(338, 279);
            this.mAMHTextEdit.Name = "mAMHTextEdit";
            this.mAMHTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mAMHTextEdit.TabIndex = 7;
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(265, 308);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(67, 19);
            tENMHLabel.TabIndex = 8;
            tENMHLabel.Text = "TENMH:";
            // 
            // tENMHTextEdit
            // 
            this.tENMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "TENMH", true));
            this.tENMHTextEdit.Location = new System.Drawing.Point(338, 305);
            this.tENMHTextEdit.Name = "tENMHTextEdit";
            this.tENMHTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tENMHTextEdit.TabIndex = 9;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(325, 341);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(548, 290);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmMonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 389);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.mAMHTextEdit);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.tENMHTextEdit);
            this.Controls.Add(this.mONHOCGridControl);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMonhoc";
            this.Text = "Môn học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMonhoc_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLTN_CS1_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbKetqua;
        private QLTN_CS1_DataSet qLTN_CS1_DataSet;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLTN_CS1_DataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private QLTN_CS1_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl mONHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MAMH;
        private DevExpress.XtraGrid.Columns.GridColumn TENMH;
        private DevExpress.XtraEditors.TextEdit mAMHTextEdit;
        private DevExpress.XtraEditors.TextEdit tENMHTextEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}