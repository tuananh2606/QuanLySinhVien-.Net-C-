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
    public partial class frmQuanLyNguoiDung : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;
        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
            txtTaikhoan.ReadOnly = true;
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            //Kiem tra trung TenDN
            string select2 = "Select * From tblLOGIN where TenDN='" + txtTaikhoan.Text + "'";
            SqlCommand cmd2 = new SqlCommand(select2, conn);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();

            errorProvider1.Clear();
            if (txtTaikhoan.Text == "")
            {
                errorProvider1.SetError(txtTaikhoan, "Tên tài khoản không  để trống !");
                txtTaikhoan.Focus();
            }
            else if (txtMK.Text == "")
            {
                errorProvider1.SetError(txtMK, "Bạn chưa nhập mật khẩu !");
                txtMK.Focus();
            }
            else if (txtConfimMk.Text == "")
            {
                errorProvider1.SetError(txtConfimMk, "Bạn chưa nhập lại mật khẩu !");
                txtConfimMk.Focus();
            }
            else if (txtConfimMk.Text != txtMK.Text)
           
                MessageBox.Show("Bạn nhập lại mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            else if (reader2.Read())
            {
                MessageBox.Show("Tài khoản " + txtTaikhoan.Text + " đã tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaikhoan.Focus();
                cmd2.Dispose();
                reader2.Dispose();
            }
            else
            {
                // Trả tài nguyên
                cmd2.Dispose();
                reader2.Dispose();
                // Thực hiện truy vấn
                string insert = "Insert Into tblLOGIN(TenDN,MatKhau,HoTen,Gioitinh,Phone,Email,Quyen)" +
                                "Values('" + txtTaikhoan.Text + "','" + txtMK.Text + "',N'" + txtHoTen.Text + "',N'" + cboGioiTinh.Text + "','" +
                                mskPhone.Text + "','" + txtEmail.Text + "',N'" + cboQuyen.Text + "')";
                //SqlCommand cmd = new SqlCommand(insert, conn);
                int i = DAO.DataProvider.Instance.ExecuteNonQuery(insert);
                //int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Thêm mới thành công", "Thông báo!");
                }
                else
                {
                    MessageBox.Show("Thêm lỗi", "Thông báo!");
                }
                // Trả tài nguyên
                //cmd.Dispose();

            }
            // Trả tài nguyên
            cmd2.Dispose();
            reader2.Dispose();
            //Fill du lieu 
            FillDataGridView_Login();
        }

        private void frmQuanLyNguoiDung_Load_1(object sender, EventArgs e)
        {

        }
        public void FillDataGridView_Login()
        {
            string select = "Select * From tblLOGIN  ";
            dgrLogin1.DataSource = DAO.DataProvider.Instance.ExecuteQuery(select);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Thuc hien xoa du lieu
                string query = "delete from tblLOGIN where TenDN = '" + txtTaikhoan.Text + "'";
                DAO.DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                //Fill du lieu 
                FillDataGridView_Login();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtTaikhoan.Text == "")
                errorProvider1.SetError(txtTaikhoan, "Tên tài khoản không để trống!");
            else
            {
                // Thực hiện truy vấn
                string update = "Update tblLOGIN Set MatKhau=N'" + txtMK.Text + "',HoTen=N'" + txtHoTen.Text + "',GioiTinh=N'" +
                                cboGioiTinh.Text + "',Phone='" + mskPhone.Text + "',Email='" +
                                txtEmail.Text + "',Quyen=N'" + cboQuyen.Text + "' where TenDN='" + txtTaikhoan.Text + "'";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();
                //DAO.DataProvider.Instance.ExecuteNonQuery(update);
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                //Load lai du lieu
                FillDataGridView_Login();
                // Trả tài nguyên
                cmd.Dispose();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int selectedRow;
        private void dgrLogin1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow < 0) { return; }
            txtTaikhoan.Text = dgrLogin1.CurrentRow.Cells[0].Value.ToString();
            txtMK.Text = dgrLogin1.CurrentRow.Cells[1].Value.ToString();
            txtHoTen.Text = dgrLogin1.CurrentRow.Cells[2].Value.ToString();
            cboGioiTinh.Text = dgrLogin1.CurrentRow.Cells[3].Value.ToString();
            mskPhone.Text = dgrLogin1.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgrLogin1.CurrentRow.Cells[5].Value.ToString();
            cboQuyen.Text = dgrLogin1.CurrentRow.Cells[6].Value.ToString();
        }

        private void frmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            conn = cc.Connected();
            if (conn.State == ConnectionState.Open) ;
            string sql = "select * from tblLOGIN";
            SqlCommand commandsql = new SqlCommand(sql, conn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable table = new DataTable();
            com.Fill(table);
            dgrLogin1.DataSource = table;
        }
    }
}
