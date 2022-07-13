using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Diagnostics;

namespace QuanLySinhVien
{
    public partial class frmMonHoc : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            
            conn = cc.Connected();
            if (conn.State == ConnectionState.Open) ;
            string sqlkhoa = "select * from  [Quanlydiem].[dbo].[tblMON]";
            SqlCommand comand = new SqlCommand(sqlkhoa, conn);
            SqlDataAdapter sqlcom = new SqlDataAdapter(comand);
            DataTable table = new DataTable();
            sqlcom.Fill(table);
            dgrMON1.DataSource = table;
            
            string select = "Select MaKhoa from tblKHOA ";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboKhoa.Items.Add(reader.GetString(0));
            }
            reader.Dispose();
            cmd.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select1 = "Select MaMon from tblMON where MaMon='" + txtMaMon.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(select1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            errorProvider1.Clear();
            if (txtMaMon.Text == "")
            {
                errorProvider1.SetError(txtMaMon, "Mã môn không để trống!");
            }
            else if (reader1.Read())
            {
                {
                    MessageBox.Show("Bạn đã nhập thông tin cho môn: " + txtTenMon.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaMon.Focus();

                }

                
                //Tra tai nguyen 
                reader1.Dispose();
                cmd1.Dispose();
            }
            else
            {
                reader1.Dispose();
                cmd1.Dispose();
                // Thực hiện truy vấn
                string insert = "Insert Into tblMON(MaMon,TenMon,MaGV,HocKi,MaKhoa)" +
                "Values('" + txtMaMon.Text + "',N'" + txtTenMon.Text + "','" + txtMaGV.Text + "','" + txtHocKy.Text + "','" + cboKhoa.Text + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nhập thông tin thành công", "Thông báo!");

                // Trả tài nguyên


                cmd.Dispose();
                //Fill du lieu vao Database
                FillDataGridView_MON();
            }
            reader1.Dispose();
            cmd1.Dispose();
        }
        public void FillDataGridView_MON()
        {
            string select = "Select * From tblMON  ";
            dgrMON1.DataSource = DAO.DataProvider.Instance.ExecuteQuery(select);
            foreach (DataGridViewColumn column in dgrMON1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Thuc hien xoa du lieu
            
            string select1 = "Select MaMon from [Quanlydiem].[dbo].[tblKET_QUA] where MaMon='" + txtMaMon.Text + "' ";
            SqlCommand cmdDel = new SqlCommand(select1, conn);
            SqlDataReader readerDel = cmdDel.ExecuteReader();

            if (readerDel.Read())
            {
                {
                    MessageBox.Show("Bạn phải xóa Mã Môn " + txtMaMon.Text + "từ bảng tblKETQUA", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmdDel.Dispose();
                readerDel.Dispose();
                string delete = "delete from tblMON where MaMon='" + txtMaMon.Text + "' ";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");

                // Trả tài nguyên
                cmd.Dispose();
                //Load lai du lieu
                FillDataGridView_MON();
            }
            cmdDel.Dispose();
            readerDel.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Thực hiện truy vấn
            string update = "Update tblMON Set TenMon=N'" + txtTenMon.Text + "',MaGV='" + txtMaGV.Text + "',HocKi='" +
                            txtHocKy.Text + "',MaKhoa='" + cboKhoa.Text + "' where MaMon='" + txtMaMon.Text + "' ";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Load lai du lieu
            FillDataGridView_MON();
            // Trả tài nguyên
            cmd.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int selectedRow;
        private void dgrMON1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow < 0) { return; }
            txtMaMon.Text = dgrMON1.CurrentRow.Cells[0].Value.ToString();
            txtTenMon.Text = dgrMON1.CurrentRow.Cells[1].Value.ToString();
            txtMaGV.Text = dgrMON1.CurrentRow.Cells[2].Value.ToString();
            txtHocKy.Text = dgrMON1.CurrentRow.Cells[3].Value.ToString();
            cboKhoa.Text = dgrMON1.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgrMON1_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            tblMONBindingSource.Sort = dgrMON1.SortString;
        }
    }
}
