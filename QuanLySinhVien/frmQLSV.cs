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
    public partial class frmQLSV : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;

        public frmQLSV()
        {
            InitializeComponent();
        }

        string username;
        string name;
        bool check = true;

        public frmQLSV(bool check, string username)
        {
            InitializeComponent();
            this.groupBox2.Hide();
            this.btnThemmoi.Hide();
            this.btnSua.Hide();
            this.btnXoa.Hide();

            this.username = username;
            this.check = check;
        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            conn=cc.Connected();
            if (conn.State == ConnectionState.Open) ;
            if (check)
            {
                //Add du lieu vao cboKhoa
                string select = "Select MaKhoa from tblKHOA ";
                SqlCommand cmd = new SqlCommand(select, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    //cboKhoahoc.Items.Add(reader.GetString(0));
                }
                reader.Dispose();
                cmd.Dispose();


                //Add du lieu vao MaLop
                string selects = "Select MaLop from tblLOP";
                SqlCommand cmd1 = new SqlCommand(selects, conn);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {

                    cboMalop.Items.Add(reader1.GetString(0));
                }
                reader1.Dispose();
                cmd1.Dispose();
                //Load lai du lieu
                FillDataGridView_SV();
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

                string sql = "select * from [Quanlydiem].[dbo].[tblSINH_VIEN] where HoTen='" + name + "'";
                dgrDSSV1.DataSource = DAO.DataProvider.Instance.ExecuteQuery(sql);

            }
            
        }
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            //Kiem tra trung ten MaSV
            string select2 = "Select * From tblSINH_VIEN where Masv='" + txtMaSV.Text + "'";
            SqlCommand cmd2 = new SqlCommand(select2, conn);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();

            errorProvider1.Clear();
            if (txtMaSV.Text == "")
            {
                errorProvider1.SetError(txtMaSV, "Mã sinh viên không để trống!");
            }
            else if (cboMalop.Text == "")
            {
                errorProvider1.SetError(cboMalop, "Mã lớp không để trống!");
            }
            else if (reader2.Read())
            {
                MessageBox.Show("Bạn đã nhập trùng mã sinh viên ", "Thông báo !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtMaSV.Focus();
                cmd2.Dispose();
                reader2.Dispose();
            }
            else
            {
                // Trả tài nguyên
                cmd2.Dispose();
                reader2.Dispose();
                // Thực hiện truy vấn
                string insert = "Insert Into tblSINH_VIEN(MaSV,HoTen,Ngaysinh,Gioitinh,DiaChi,Malop)" +
                                "Values('" + txtMaSV.Text + "',N'" + txtHoTen.Text + "','" +
                                mskNgaySinh.Text + "',N'" + cboGioiTinh.Text + "',N'" + txtDiaChi.Text + "','" +
                                cboMalop.Text + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công", "Thông báo!");

                // Trả tài nguyên

                cmd.Dispose();
            }
            // Trả tài nguyên
            cmd2.Dispose();
            reader2.Dispose();
            //Load lai du lieu
            FillDataGridView_SV();

            
        }
        public void FillDataGridView_SV()
        {
            //string select = "Select * From tblSINH_VIEN";
            //dgrDSSV1.DataSource = DAO.DataProvider.Instance.ExecuteQuery(select);
            //SqlCommand cmd = new SqlCommand(select, conn);

            //// Tạo đối tượng DataSet
            //DataSet ds = new DataSet();

            //// Tạo đối tượng điều hợp
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.SelectCommand = cmd;

            //// Fill dữ liệu từ adapter vào DataSet
            //adapter.Fill(ds, "SINHVIEN");

            //// Đưa ra DataGridView
            //dgrDSSV1.DataSource = ds;
            //dgrDSSV1.DataMember = "SINHVIEN";
            //cmd.Dispose();
            try
            {
                this.tblSINH_VIENTableAdapter5.Fill(this.quanlydiemDataSet5.tblSINH_VIEN);
            }
            catch (Exception ex){ }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Kiem tra 

            string select1 = "Select MaSv from tblKET_QUA where MaSv='" + txtMaSV.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(select1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                {
                    MessageBox.Show("Bạn phải xóa Mã Sinh viên " + txtMaSV.Text + "từ bảng Kết quả học tập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reader1.Dispose();
                cmd1.Dispose();
                // Thuc hien xoa du lieu

                SqlCommand cmd = new SqlCommand("delete from tblSINH_VIEN where MaSv='" + txtMaSV.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");

                // Trả tài nguyên
                cmd.Dispose();
                //Load lai du lieu
                FillDataGridView_SV();
            }
            reader1.Dispose();
            cmd1.Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtMaSV.Text == "")
            errorProvider1.SetError(txtMaSV, "Mã sinh viên không để trống!");
            else if (cboMalop.Text == "")
            errorProvider1.SetError(cboMalop, "Mã lớp không để trống!");


            else
            {
            // Thực hiện truy vấn
            string update = "Update tblSINH_VIEN Set HoTen=N'" + txtHoTen.Text + "',NgaySinh='" +
                            mskNgaySinh.Text + "',GioiTinh=N'" + cboGioiTinh.Text + "',DiaChi=N'" +
                            txtDiaChi.Text + "',MaLop='" + cboMalop.Text + "'where MaSV='" + txtMaSV.Text + "'";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
            //Load lai du lieu
            FillDataGridView_SV();
            // Trả tài nguyên
            cmd.Dispose();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int selectedRow;
        private void dgrDSSV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow < 0) { return; }
            txtMaSV.Text = dgrDSSV1.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgrDSSV1.CurrentRow.Cells[1].Value.ToString();
            mskNgaySinh.Text = dgrDSSV1.CurrentRow.Cells[2].Value.ToString();
            cboGioiTinh.Text = dgrDSSV1.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = dgrDSSV1.CurrentRow.Cells[4].Value.ToString();
            cboMalop.Text = dgrDSSV1.CurrentRow.Cells[5].Value.ToString();
        }

        private void dgrDSSV1_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            tblSINHVIENBindingSource8.Sort = dgrDSSV1.SortString;
        }

        private void dgrDSSV1_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            tblSINHVIENBindingSource8.Filter = dgrDSSV1.FilterString;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Thaotac.Export2Excel(dgrDSSV1);
        }
    }
}
