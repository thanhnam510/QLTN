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
    public partial class frmMonhoc2 : Form
    {
        public frmMonhoc2()
        {
            InitializeComponent();
        }


        private void frmMonhoc2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTN_CS1_DataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLTN_CS1_DataSet.MONHOC);
            // TODO: This line of code loads data into the 'qLTN_CS1_DataSet.MONHOC' table. You can move, or remove it, as needed.
            mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLTN_CS1_DataSet.MONHOC);
            this.Width = SystemInformation.VirtualScreen.Width;
            mONHOCGridControl.Width =  this.Width;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int [] ds = gridView1.GetSelectedRows();
            String kq = "";
            foreach (int a in ds)
            {
                DataRow dr = gridView1.GetDataRow(a);
                try
                {
                    mONHOCTableAdapter.Delete(dr["MAMH",DataRowVersion.Original].ToString(),dr["TENMH", DataRowVersion.Original].ToString());

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                        kq += dr["MAMH", DataRowVersion.Original].ToString() + " ";
                    else
                        MessageBox.Show(ex.Message + ex.Number);
                }
            }
            if (kq !="")
                MessageBox.Show(kq + "đang được dùng ở bảng khác.\n Không thể xóa.","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            refresh();
        }
        private void refresh()
        {

            //mONHOCTableAdapter.Fill(qLTN_CS1_DataSet.MONHOC);
        }

        private void btnLammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            refresh();
        }

        private void btnLuu_Click(object sender, EventArgs e) { 
            if(txtMAMH.Text == "")
            {
                lbAlert.Text = "Mã môn học không được trống";
                txtMAMH.Focus();
                return;
            }

            if (ciThem.Checked)
            {
                try
                {
                    mONHOCTableAdapter.Insert(txtMAMH.Text, txtTENMH.Text);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        lbAlert.Text = "Mã môn học hoặc tên môn học đã tồn tại.";
                    else
                        lbAlert.Text = ex.Message + ex.Number;
                    return;
                }
                return;
            }
            DataRow dr = gridView1.GetDataRow(bds_monhoc.Position);
            try
            {
                dr["MAMH"] = txtMAMH.Text.Trim();
                dr["TENMH"] = txtTENMH.Text.Trim();
                mONHOCTableAdapter.Update(qLTN_CS1_DataSet.MONHOC);
                txtMAMH.Text = txtTENMH.Text = "";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    lbAlert.Text = "Mã môn học hoặc tên môn học đã tồn tại.";
                else
                    lbAlert.Text = ex.Message + ex.Number;
            }

        }


        private void ciThem_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ciThem.Checked)
            {
                grMonhoc.Enabled = true;
                ciSua.Checked = false;
                txtMAMH.Text = "";
                txtTENMH.Text = "";
                txtMAMH.Focus();
            }
        }

        private void ciSua_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ciSua.Checked)
            {
                grMonhoc.Enabled = true;
                ciThem.Checked = false;
                DataRow dr = gridView1.GetDataRow(bds_monhoc.Position);
                txtMAMH.Text = dr["MAMH"].ToString().Trim();
                txtTENMH.Text = dr["TENMH"].ToString().Trim();
                txtMAMH.Focus();
            }
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (!ciSua.Checked)
                return;
            DataRow dr = gridView1.GetDataRow(bds_monhoc.Position);
            txtMAMH.Text = dr["MAMH"].ToString().Trim();
            txtTENMH.Text = dr["TENMH"].ToString().Trim();
        }
    }
}
