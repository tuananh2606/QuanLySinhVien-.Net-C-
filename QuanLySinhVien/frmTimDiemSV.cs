using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    public partial class frmTimDiemSV : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;
        public frmTimDiemSV()
        {
            InitializeComponent();
        }
        string username;
        string name;
        bool check = true;

        public frmTimDiemSV(bool check, string username)
        {
            InitializeComponent();
            this.groupBox2.Hide();
            this.btnTimKiem.Hide();
            this.btnXuat.Show();

            this.username = username;
            this.check = check;        
        }

        private void frmTimDiemSV_Load(object sender, EventArgs e)
        {
            conn = cc.Connected();
            if (conn.State == ConnectionState.Open) ;
            if (check) 
            {
                string sql = "select * from [Quanlydiem].[dbo].[tblKET_QUA]";
                dgrDIEMSV1.DataSource = DAO.DataProvider.Instance.ExecuteQuery(sql);
            }
            else
            {
                string select = "select HoTen from [Quanlydiem].[dbo].[tblLOGIN] where TenDN='" + username + "'";
                SqlCommand cmd = new SqlCommand(select, conn);
                SqlDataAdapter sda = new SqlDataAdapter(select, conn);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                
                foreach (DataRow row in dt.Rows)
                {
                    name = row["HoTen"].ToString();
                }
                cmd.Dispose();

                string sql = "select * from [Quanlydiem].[dbo].[tblKET_QUA] where HoTen='" + name + "'";
                dgrDIEMSV1.DataSource = DAO.DataProvider.Instance.ExecuteQuery(sql);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string select = "Select * From tblKET_QUA  where MaSV='" + txtMaSV.Text + "' and MaMon=N'" + cboMonHoc.Text + "'";
                dgrDIEMSV1.DataSource = DAO.DataProvider.Instance.ExecuteQuery(select);  
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Thaotac.Export2Excel(dgrDIEMSV1);
        }
    }
}