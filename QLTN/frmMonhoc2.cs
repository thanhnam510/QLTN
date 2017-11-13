using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // TODO: This line of code loads data into the 'qLTNDataSet.MONHOC' table. You can move, or remove it, as needed.
            mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLTNDataSet.MONHOC);
            this.Width = SystemInformation.VirtualScreen.Width;
            mONHOCGridControl.Width =  this.Width;
            DataTable tb = qLTNDataSet.MONHOC;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int [] ds = gridView1.GetSelectedRows();
            foreach (int a in ds)
            {
                bds_monhoc.RemoveAt(a);
                try
                {
                    bds_monhoc.Position =
                    mONHOCTableAdapter.Update(qLTNDataSet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    bds_monhoc.ResetCurrentItem();
                }
                
            }
        }

        private void btnLammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_monhoc.ResetCurrentItem();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataRow dr;
            if (ciThem.Checked)
            {
                dr = qLTNDataSet.MONHOC.NewRow();
                dr["MAMH"] = txtMAMH.Text;
                dr["TENMH"] = txtTENMH.Text;
                try
                {
                    qLTNDataSet.MONHOC.Rows.Add(dr);
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                bds_monhoc.EndEdit();
                mONHOCTableAdapter.Update(qLTNDataSet.MONHOC);
                bds_monhoc.ResetCurrentItem();
            }
            dr = gridView1.GetDataRow(bds_monhoc.Position);
            try
            {
                dr["MAMH"] = txtMAMH.Text;
                dr["TENMH"] = txtTENMH.Text;
                bds_monhoc.EndEdit();
                mONHOCTableAdapter.Update(qLTNDataSet.MONHOC);
                bds_monhoc.ResetCurrentItem();
                txtMAMH.Text = txtTENMH.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (!ciSua.Checked)
                return;
            DataRow dr = gridView1.GetDataRow(bds_monhoc.Position);
            txtMAMH.Text = dr["MAMH"].ToString();
            txtTENMH.Text = dr["TENMH"].ToString();
        }

        private void ciThem_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ciThem.Checked)
                ciSua.Checked = false;
        }

        private void ciSua_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ciSua.Checked)
                ciThem.Checked = false;
        }

    }
}
