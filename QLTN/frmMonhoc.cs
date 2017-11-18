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
        }

        private void frmMonhoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTN_CS1_DataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLTN_CS1_DataSet.MONHOC);
            //layBang();
            

        }




        private void simpleButton2_Click(object sender, EventArgs e)
        {
            mONHOCGridControl.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            mONHOCBindingSource.EndEdit();
            mONHOCTableAdapter.Update(qLTN_CS1_DataSet.MONHOC);
            mONHOCBindingSource.ResetCurrentItem();
            mONHOCGridControl.Enabled = true;
        }
    }
}
