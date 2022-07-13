using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;

        string username;

        public frmMain(string username) : this()
        {
            this.username = username;
            conn = cc.Connected();
            string select = "Select HoTen From tblLOGIN where TenDN='" + username + "'";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataAdapter sda = new SqlDataAdapter(select, conn);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                labelUserName.Text = row["HoTen"].ToString();

            }

            cmd.Dispose();
        }

        public static bool kt1, kt2;

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        frmDoiMatKhau frmDoiMatKhau = null;
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDoiMatKhau != null)
            {
                frmDoiMatKhau.BringToFront();
            }
            else
            {
                frmDoiMatKhau = new frmDoiMatKhau(username);
                frmDoiMatKhau.Show();
            }
            if (frmDoiMatKhau.IsDisposed)
            {
                frmDoiMatKhau = new frmDoiMatKhau(username);
                frmDoiMatKhau.Show();
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }



        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            
        }

        private void MnuDN_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Hide();
          }

        frmMonHoc frmMonHoc = null;
        private void mnuMon_Click(object sender, EventArgs e)
        {
            if (frmMonHoc != null)
            {
                frmMonHoc.BringToFront();
            }
            else
            {
                frmMonHoc = new frmMonHoc();
                frmMonHoc.Show();
            }
            if (frmMonHoc.IsDisposed)
            {
                frmMonHoc = new frmMonHoc();
                frmMonHoc.Show();
            }
        }
        frmKhoa frmKhoa = null;
        private void mnuKhoa_Click(object sender, EventArgs e)
        {

            if (frmKhoa != null)
            {
                frmKhoa.BringToFront();
            }
            else
            {
                frmKhoa = new frmKhoa();
                frmKhoa.Show();
            }
            if (frmKhoa.IsDisposed)
            {
                frmKhoa = new frmKhoa();
                frmKhoa.Show();
            }
        }

        frmQLSV frmQLSV = null;
        private void mnuSV_Click(object sender, EventArgs e)
        {
            if (frmQLSV != null)
            {
                frmQLSV.BringToFront();
            }
            else
            {
                frmQLSV = new frmQLSV();
                frmQLSV.Show();
            }
            if (frmQLSV.IsDisposed)
            {
                frmQLSV = new frmQLSV();
                frmQLSV.Show();
            }

        }
        frmGiangVien frmGiangVien = null;
        private void mnuGV_Click(object sender, EventArgs e)
        {
            if (frmGiangVien != null)
            {
                frmGiangVien.BringToFront();
            }
            else
            {
                frmGiangVien = new frmGiangVien();
                frmGiangVien.Show();
            }
            if (frmGiangVien.IsDisposed)
            {
                frmGiangVien = new frmGiangVien();
                frmGiangVien.Show();
            }
        }

        frmQLDiem frmQLDiem = null;
        private void mnuDiem_Click(object sender, EventArgs e)
        {
            if (frmQLDiem != null)
            {
                frmQLDiem.BringToFront();
            }
            else
            {
                frmQLDiem = new frmQLDiem();
                frmQLDiem.Show();
            }
            if (frmQLDiem.IsDisposed)
            {
                frmQLDiem = new frmQLDiem();
                frmQLDiem.Show();
            }
        }

        frmQLDiemThiLai frmQLDiemThiLai = null;
        private void mnuTL_Click(object sender, EventArgs e)
        {
            if (frmQLDiemThiLai != null)
            {
                frmQLDiemThiLai.BringToFront();
            }
            else
            {
                frmQLDiemThiLai = new frmQLDiemThiLai();
                frmQLDiemThiLai.Show();
            }
            if (frmQLDiemThiLai.IsDisposed)
            {
                frmQLDiemThiLai = new frmQLDiemThiLai();
                frmQLDiemThiLai.Show();
            }
        }

        frmQLDiemHoclai frmQLDiemHoclai = null;
        private void mnuHL_Click(object sender, EventArgs e)
        {
            if (frmQLDiemHoclai != null)
            {
                frmQLDiemHoclai.BringToFront();
            }
            else
            {
                frmQLDiemHoclai = new frmQLDiemHoclai();
                frmQLDiemHoclai.Show();
            }
            if (frmQLDiemHoclai.IsDisposed)
            {
                frmQLDiemHoclai = new frmQLDiemHoclai();
                frmQLDiemHoclai.Show();
            }
        }

        frmDSThiLai frmDSThiLai = null;
        private void mnuDSTL_Click(object sender, EventArgs e)
        {
            if (frmDSThiLai != null)
            {
                frmDSThiLai.BringToFront();
            }
            else
            {
                frmDSThiLai = new frmDSThiLai();
                frmDSThiLai.Show();
            }
            if (frmDSThiLai.IsDisposed)
            {
                frmDSThiLai = new frmDSThiLai();
                frmDSThiLai.Show();
            }
        }

        frmTimDiemSV frmTimDiemSV = null;
        private void mnuThongtinSV_Click(object sender, EventArgs e)
        {
            if (frmTimDiemSV != null)
            {
                frmTimDiemSV.BringToFront();
            }
            else
            {
                frmTimDiemSV = new frmTimDiemSV();
                frmTimDiemSV.Show();
            }
            if (frmTimDiemSV.IsDisposed)
            {
                frmTimDiemSV = new frmTimDiemSV();
                frmTimDiemSV.Show();
            }
        }
        private void mnuDSSV_Click(object sender, EventArgs e)
        {

        }
        private void mnuDiemTK_Click(object sender, EventArgs e)
        {

        }

        frmQuanLyNguoiDung frmQuanLyNguoiDung = null;
        private void mnuQuanlinguoidung_Click(object sender, EventArgs e)
        {
            if (frmQuanLyNguoiDung != null)
            {
                frmQuanLyNguoiDung.BringToFront();
            }
            else
            {
                frmQuanLyNguoiDung = new frmQuanLyNguoiDung();
                frmQuanLyNguoiDung.Show();
            }
            if (frmQuanLyNguoiDung.IsDisposed)
            {
                frmQuanLyNguoiDung = new frmQuanLyNguoiDung();
                frmQuanLyNguoiDung.Show();
            }
        }

        private void mnuDX_Click_1(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Hide();
            mnuDN.Enabled = true;
            //editMenu.Enabled = false;
            mnuDoiMK.Enabled = false;
            MnuItemDanhMuc.Enabled = false;
            mnuItemQuanli.Enabled = false;
            mnuWindows.Enabled = false;


            menuBarToolStripMenuItem.Checked = false;
            //pictureBox2.Hide();
            btl1.Hide();
            btl2.Hide();
            btl3.Hide();
            btl4.Hide();
            btl5.Hide();
            btl6.Hide();
            btl7.Hide();
            btl8.Hide();


        }

        private void menuBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pictureBox2.Visible = menuBarToolStripMenuItem.Checked;
            btl1.Visible = menuBarToolStripMenuItem.Checked;
            btl2.Visible = menuBarToolStripMenuItem.Checked;
            btl3.Visible = menuBarToolStripMenuItem.Checked;
            btl4.Visible = menuBarToolStripMenuItem.Checked;
            btl5.Visible = menuBarToolStripMenuItem.Checked;
            btl6.Visible = menuBarToolStripMenuItem.Checked;

        }

        private void btl1_Click_1(object sender, EventArgs e)
        {
            loadform(new frmQLSV());
        }

        private void btl2_Click_1(object sender, EventArgs e)
        {
            loadform(new frmGiangVien());
        }

        private void btl5_Click(object sender, EventArgs e)
        {
            loadform(new frmLop());    
        }

        private void btl6_Click_1(object sender, EventArgs e)
        {
            loadform(new frmMonHoc());
        }

        private void btl3_Click(object sender, EventArgs e)
        {
            loadform(new frmQLDiem());
        }

        private void btl120_Click(object sender, EventArgs e)
        {
            loadform(new frmTimDiemSV());
        }

        private void btl4_Click(object sender, EventArgs e)
        {
            loadform(new frmKhoa());
        }
        frmLop frmLop = null;
        private void mnuLop_Click(object sender, EventArgs e)
        {
            if (frmLop != null)
            {
                frmLop.BringToFront();
            }
            else
            {
                frmLop = new frmLop();
                frmLop.Show();
            }
            if (frmLop.IsDisposed)
            {
                frmLop = new frmLop();
                frmLop.Show();
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btl7_Click(object sender, EventArgs e)
        {
            if (frmQLSV != null)
            {
                frmQLSV.BringToFront();
            }
            else
            {
                frmQLSV = new frmQLSV(false,username);
                frmQLSV.Show();
            }
            if (frmQLSV.IsDisposed)
            {
                frmQLSV = new frmQLSV(false,username);
                frmQLSV.Show();
            }
        }

        private void btl8_Click(object sender, EventArgs e)
        {
            if (frmTimDiemSV != null)
            {
                frmTimDiemSV.BringToFront();
            }
            else
            {
                frmTimDiemSV = new frmTimDiemSV(false,username);
                frmTimDiemSV.Show();
               
            }
            if (frmTimDiemSV.IsDisposed)
            {
                frmTimDiemSV = new frmTimDiemSV(false,username);
                frmTimDiemSV.Show();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            mnuDX_Click_1(null, null);
        }
    }
}
