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
using System.IO;

namespace QuanLySinhVien
{
    public partial class frmGiangVien : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;
        public frmGiangVien()
        {
            InitializeComponent();
        }
        private void frmGiangVien_Load(object sender, EventArgs e)
        {
          
            conn = cc.Connected();
            if (conn.State == ConnectionState.Open) ;
            string sql = "select * from [Quanlydiem].[dbo].[tblGIANG_VIEN]";
            SqlCommand commandsql = new SqlCommand(sql, conn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable table = new DataTable();
            com.Fill(table);
            dgrDSGV1.DataSource = table;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Kiem tra trung ten MaSV
            string select2 = "Select * From tblGIANG_VIEN where MaGV='" + txtMaGV.Text + "'";
            SqlCommand cmd2 = new SqlCommand(select2, conn);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();

            errorProvider1.Clear();
            if (txtMaGV.Text == "")
            {
                errorProvider1.SetError(txtMaGV, "Mã giảng viên không để trống!");
            }

            else if (reader2.Read())
            {
                MessageBox.Show("Bạn đã nhập trùng mã giảng viên", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaGV.Focus();
                cmd2.Dispose();
                reader2.Dispose();
            }
            else
            {
                // Trả tài nguyên
                cmd2.Dispose();
                reader2.Dispose();
                // Thực hiện truy vấn
                string insert = "Insert Into tblGIANG_VIEN(MaGV,TenGV,Gioitinh,Phone,Email,PhanloaiGV)" +
                                "Values('" + txtMaGV.Text + "',N'" + txtHoTen.Text + "',N'" + cboGioiTinh.Text + "','" +
                                mskPhone.Text + "','" + txtEmail.Text + "',N'" + cboPhanloai.Text + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công", "Thông báo!");

                // Trả tài nguyên
                cmd.Dispose();

            }
            // Trả tài nguyên
            cmd2.Dispose();
            reader2.Dispose();
            //Fill du lieu 
            FillDataGridView_GV();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
        public void FillDataGridView_GV()
        {
            string select = "Select * From tblGIANG_VIEN  ";
            dgrDSGV1.DataSource = DAO.DataProvider.Instance.ExecuteQuery(select);
            foreach (DataGridViewColumn column in dgrDSGV1.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string select1 = "Select MaGV from tblMON where MaGV='" + txtMaGV.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(select1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                {
                    MessageBox.Show("Bạn phải xóa Mã GV " + txtMaGV.Text + "từ bảng tblMON", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Thuc hien xoa du lieu
                reader1.Dispose();
                cmd1.Dispose();
                SqlCommand cmd = new SqlCommand("delete from tblGIANG_VIEN where MaGV='" + txtMaGV.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");

                // Trả tài nguyên
                cmd.Dispose();
                //Load lai du lieu
                FillDataGridView_GV();
            }
            cmd1.Dispose();
            reader1.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtMaGV.Text == "")
                errorProvider1.SetError(txtMaGV, "Mã giảng viên không để trống!");
            else
            {
                // Thực hiện truy vấn
                string update = "Update tblGIANG_VIEN Set TenGV=N'" + txtHoTen.Text + "',GioiTinh=N'" + 
                                cboGioiTinh.Text + "',Phone='" + mskPhone.Text + "',Email='" + 
                                txtEmail.Text + "',PhanLoaiGV=N'" + cboPhanloai.Text + "' where MaGV='" + txtMaGV.Text + "'";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                //Load lai du lieu
                FillDataGridView_GV();
                // Trả tài nguyên
                cmd.Dispose();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int selectedRow;
        private void dgrDSGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow < 0) { return; }
            txtMaGV.Text = dgrDSGV1.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgrDSGV1.CurrentRow.Cells[1].Value.ToString();
            cboGioiTinh.Text = dgrDSGV1.CurrentRow.Cells[2].Value.ToString();
            mskPhone.Text = dgrDSGV1.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgrDSGV1.CurrentRow.Cells[4].Value.ToString();
            cboPhanloai.Text = dgrDSGV1.CurrentRow.Cells[5].Value.ToString();
        }

        private void dgrDSGV1_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            tblGIANGVIENBindingSource3.Filter = dgrDSGV1.FilterString;
        }

        private void dgrDSGV1_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            tblGIANGVIENBindingSource3.Sort = dgrDSGV1.SortString;
        }
    }
}
