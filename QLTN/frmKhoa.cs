﻿using System;
using System.Data;
using System.Windows.Forms;

namespace QLTN
{
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qltnDataSet1.v_ds_phanmanh' table. You can move, or remove it, as needed.
            //          for (int i = 0; i < ; i++)
            //        {
            //          String cs = qltnDataSet1.v_ds_phanmanh[i].COSO;
            DataTable tb = new DataTable();
            String tensv = " DESKTOP-1QMSKRU\\NAM ";
            Program.connstr = "Data Source = DESKTOP-1QMSKRU\\NAM; Initial Catalog = " +
                      Program.database + ";User ID= sa" +
                      ";password=123";
            String strLenh = "Select MACS from [dbo].[COSO]";
            Program.conn.ConnectionString = Program.connstr;
            tb = Program.ExecSqlDataTable(strLenh);
             cbCS.Items.AddRange(new String[] { "Cơ sở 1" ,"Cơ sở 2"});
             DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rps = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            rps.DataSource = tb;
            rps.AutoHeight = true;
            rps.DropDownRows = tb.Rows.Count;
            rps.DisplayMember = "MACS";
            rps.ShowFooter = false;
            rps.ShowHeader = false;
            rps.ValueMember = "MACS";
            gridView1.Columns[2].ColumnEdit = rps;
            //          }
            khoaTableAdapter1.Fill(this.qltnDataSet1.KHOA);
        }
    }
}
