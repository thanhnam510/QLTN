﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace QLTN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            frmChinh = new frmMain();
            //Application.Run(frmChinh);
            Application.Run(frmChinh);
        }
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String servername = "";
        public static String username = "";
        public static String password = "";
        public static String mlogin = "";

        public static String database = "QLTN";
        public static String remotelogin = "";
        public static String remotepassword = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mCoso = -1;

        public static BindingSource bds_dspm = new BindingSource();
        public static frmMain frmChinh;

        public static int KetNoi()
        {
            if(Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" + 
                      Program.database + ";User ID=" + 
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = connstr;
                Program.conn.Open();
                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL.\nBạn xem lại username và password.\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String strLenh)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(strLenh, Program.conn);
            da.Fill(dt);
            conn.Close();
            return dt;

        } 

        public static int ExecSqlNonQuery(String strLenh)
        {
            int count = 0;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlCommand sqlcmd = Program.conn.CreateCommand();
            try
            {
                sqlcmd.CommandText = strLenh;
                count = sqlcmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                Program.conn.Close();
            }
            return count;
        }
    }
}
