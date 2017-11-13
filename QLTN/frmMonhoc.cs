using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTN
{
    public partial class frmMonhoc : Form
    {
        private List<DataRow> dsSua;
        private List<DataRow> dsThem;

        public frmMonhoc()
        {
            InitializeComponent();
            dsSua = new List<DataRow>();
            dsThem = new List<DataRow>();
        }

        private void frmMonhoc_Load(object sender, EventArgs e)
        {
            monhocTableAdapter1.Connection.ConnectionString = Program.connstr;
            monhocTableAdapter1.Fill(qltnDataSet1.MONHOC);
            //layBang();
            

        }
        private void layBang()
        {
            DataTable tb =qltnDataSet1.MONHOC;
            gcMonhoc.DataSource = tb;
            
        }


        private int  them()
        {
            String strLenh ="";
            foreach (DataRow dr in dsThem)
            {
                strLenh += "Insert into [dbo].[MONHOC] (MAMH,TENMH) values('"+ dr["MAMH"]+"','"+ dr["TENMH"] +"')\n";
                dr.AcceptChanges();
            }
            if (strLenh == "")
                return 0;
            return Program.ExecSqlNonQuery(strLenh);
        }
        private int sua()
        { 
            String strLenh = "";
            foreach (DataRow dr in dsSua)
            {
                strLenh += "Update [dbo].[MONHOC] set MAMH ='" + dr["MAMH"] + "',TENMH ='" + dr["TENMH"] +
                    "' where MAMH ='" + dr["MAMH", DataRowVersion.Original] + "'\n";              
            }
            if (strLenh == "")
                return 0;
            return Program.ExecSqlNonQuery(strLenh);
        }
        private void kTraSua()
        {
            try
            {
                for (int j = 0; j < gridView1.GetSelectedRows().Length; j++)
                {
                    DataRow dr = gridView1.GetDataRow(j);
                    if (dr.RowState == DataRowState.Modified)
                    {
                        for (int i = 0; i < dsSua.Count; i++)
                            if (dr["MAMH", DataRowVersion.Original] == dsSua[i]["MAMH", DataRowVersion.Original])
                            {
                                dsSua[i] = dr;
                                return;
                            }

                        for (int i = 0; i < dsThem.Count; i++)
                            if (dr["MAMH", DataRowVersion.Original] == dsThem[i]["MAMH", DataRowVersion.Original])
                            {
                                dsThem[i] = dr;
                                return;
                            }
                        dsSua.Add(dr);
                    }
                }
            }
            catch //bỏ qua lỗi khi refresh
            {
                return;
            }
        }
        private void gridView1_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            kTraSua();
        }
        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                int c = gridView1.RowCount;
                DataRow dr = gridView1.GetDataRow(c-2);
                if (dr.RowState == DataRowState.Added)
                {
                    dr.AcceptChanges();
                    dsThem.Add(dr);
                }
            }
            catch
            {
                return;
            }
        }

        private void bBtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            lbKetqua.Text = "Đã thêm: " + them() + " dòng, sửa: " + sua() + " dòng.";
            dsThem = new List<DataRow>();
            dsSua = new List<DataRow>();
        }

        private void bBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int count = 0;
            int []dsXoa = gridView1.GetSelectedRows();
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlCommand sqlcmd = Program.conn.CreateCommand();
            foreach (int i in dsXoa)
            {
                DataRow dr = gridView1.GetDataRow(i);
                String strLenh = "Delete from [dbo].[MONHOC] where MAMH ='" + dr["MAMH", DataRowVersion.Original]+"'\n";
                try
                {
                    sqlcmd.CommandText = strLenh;
                    count = sqlcmd.ExecuteNonQuery();
                    count++;
                }
                catch (SqlException ex)
                {
                    foreach (DataRow d in dsThem)
                        if (dr["MAMH", DataRowVersion.Original] == d["MAMH", DataRowVersion.Original])
                            continue;
                    MessageBox.Show(ex.Message);
                }
            }
            lbKetqua.Text = "Đã xóa: " + count + " dòng.";
            monhocTableAdapter1.Fill(qltnDataSet1.MONHOC);
        }

        private void bBtnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //layBang();
            monhocTableAdapter1.Fill(qltnDataSet1.MONHOC);
            lbKetqua.Text = "";
            dsThem = new List<DataRow>();
            dsSua = new List<DataRow>();
        }
    }
}
