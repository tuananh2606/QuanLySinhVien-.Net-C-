namespace QuanLySinhVien
{
    partial class frmQuanLyNguoiDung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNguoiDung));
            this.label1 = new System.Windows.Forms.Label();
            this.cboQuyen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConfimMk = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrLogin1 = new Zuby.ADGV.AdvancedDataGridView();
            this.tenDNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlydiemDataSet25 = new QuanLySinhVien.QuanlydiemDataSet25();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblLOGINTableAdapter = new QuanLySinhVien.QuanlydiemDataSet25TableAdapters.tblLOGINTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrLogin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLOGINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NGƯỜI DÙNG ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboQuyen
            // 
            this.cboQuyen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboQuyen.FormattingEnabled = true;
            this.cboQuyen.Items.AddRange(new object[] {
            "Admin",
            "Member"});
            this.cboQuyen.Location = new System.Drawing.Point(493, 135);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(181, 27);
            this.cboQuyen.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(358, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quyền:";
            // 
            // txtConfimMk
            // 
            this.txtConfimMk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtConfimMk.Location = new System.Drawing.Point(493, 96);
            this.txtConfimMk.Name = "txtConfimMk";
            this.txtConfimMk.Size = new System.Drawing.Size(182, 26);
            this.txtConfimMk.TabIndex = 15;
            // 
            // txtMK
            // 
            this.txtMK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMK.Location = new System.Drawing.Point(493, 60);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(182, 26);
            this.txtMK.TabIndex = 14;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTaikhoan.Location = new System.Drawing.Point(493, 21);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(182, 26);
            this.txtTaikhoan.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(358, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Đánh lại mật khẩu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mskPhone);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboQuyen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtConfimMk);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.txtTaikhoan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(62, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 178);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(101, 55);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(76, 27);
            this.cboGioiTinh.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(17, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 54;
            this.label7.Text = "Giới tính:";
            // 
            // mskPhone
            // 
            this.mskPhone.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPhone.ForeColor = System.Drawing.Color.Black;
            this.mskPhone.Location = new System.Drawing.Point(101, 96);
            this.mskPhone.Mask = "9999 000 000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(202, 26);
            this.mskPhone.TabIndex = 53;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(101, 135);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(202, 26);
            this.txtEmail.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(17, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "Phone:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(101, 23);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(202, 26);
            this.txtHoTen.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 48;
            this.label9.Text = "Họ và tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(358, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(358, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên tài khoản :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrLogin1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(62, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 221);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgrLogin1
            // 
            this.dgrLogin1.AutoGenerateColumns = false;
            this.dgrLogin1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrLogin1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrLogin1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDNDataGridViewTextBoxColumn1,
            this.matKhauDataGridViewTextBoxColumn1,
            this.hoTenDataGridViewTextBoxColumn1,
            this.gioiTinhDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.quyenDataGridViewTextBoxColumn1});
            this.dgrLogin1.DataSource = this.tblLOGINBindingSource;
            this.dgrLogin1.FilterAndSortEnabled = true;
            this.dgrLogin1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrLogin1.Location = new System.Drawing.Point(0, 25);
            this.dgrLogin1.Name = "dgrLogin1";
            this.dgrLogin1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgrLogin1.RowHeadersWidth = 51;
            this.dgrLogin1.RowTemplate.Height = 24;
            this.dgrLogin1.Size = new System.Drawing.Size(716, 196);
            this.dgrLogin1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrLogin1.TabIndex = 1;
            this.dgrLogin1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrLogin1_CellClick);
            // 
            // tenDNDataGridViewTextBoxColumn1
            // 
            this.tenDNDataGridViewTextBoxColumn1.DataPropertyName = "TenDN";
            this.tenDNDataGridViewTextBoxColumn1.FillWeight = 92.47312F;
            this.tenDNDataGridViewTextBoxColumn1.HeaderText = "TenDN";
            this.tenDNDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.tenDNDataGridViewTextBoxColumn1.Name = "tenDNDataGridViewTextBoxColumn1";
            this.tenDNDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.tenDNDataGridViewTextBoxColumn1.Width = 125;
            // 
            // matKhauDataGridViewTextBoxColumn1
            // 
            this.matKhauDataGridViewTextBoxColumn1.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn1.FillWeight = 111.336F;
            this.matKhauDataGridViewTextBoxColumn1.HeaderText = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.matKhauDataGridViewTextBoxColumn1.Name = "matKhauDataGridViewTextBoxColumn1";
            this.matKhauDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.matKhauDataGridViewTextBoxColumn1.Width = 125;
            // 
            // hoTenDataGridViewTextBoxColumn1
            // 
            this.hoTenDataGridViewTextBoxColumn1.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn1.FillWeight = 93.16547F;
            this.hoTenDataGridViewTextBoxColumn1.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.hoTenDataGridViewTextBoxColumn1.Name = "hoTenDataGridViewTextBoxColumn1";
            this.hoTenDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.hoTenDataGridViewTextBoxColumn1.Width = 125;
            // 
            // gioiTinhDataGridViewTextBoxColumn1
            // 
            this.gioiTinhDataGridViewTextBoxColumn1.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn1.FillWeight = 113.6313F;
            this.gioiTinhDataGridViewTextBoxColumn1.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.gioiTinhDataGridViewTextBoxColumn1.Name = "gioiTinhDataGridViewTextBoxColumn1";
            this.gioiTinhDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.gioiTinhDataGridViewTextBoxColumn1.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn1.FillWeight = 94.37253F;
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            this.phoneDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.phoneDataGridViewTextBoxColumn1.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.FillWeight = 93.62077F;
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.emailDataGridViewTextBoxColumn1.Width = 125;
            // 
            // quyenDataGridViewTextBoxColumn1
            // 
            this.quyenDataGridViewTextBoxColumn1.DataPropertyName = "Quyen";
            this.quyenDataGridViewTextBoxColumn1.FillWeight = 101.4008F;
            this.quyenDataGridViewTextBoxColumn1.HeaderText = "Quyen";
            this.quyenDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.quyenDataGridViewTextBoxColumn1.Name = "quyenDataGridViewTextBoxColumn1";
            this.quyenDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.quyenDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tblLOGINBindingSource
            // 
            this.tblLOGINBindingSource.DataMember = "tblLOGIN";
            this.tblLOGINBindingSource.DataSource = this.quanlydiemDataSet25;
            // 
            // quanlydiemDataSet25
            // 
            this.quanlydiemDataSet25.DataSetName = "QuanlydiemDataSet25";
            this.quanlydiemDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(791, 296);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 35);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(791, 255);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 35);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(791, 214);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(140, 35);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmoi.ForeColor = System.Drawing.Color.Black;
            this.btnThemmoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemmoi.Image")));
            this.btnThemmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemmoi.Location = new System.Drawing.Point(791, 173);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(140, 35);
            this.btnThemmoi.TabIndex = 21;
            this.btnThemmoi.Text = "     Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tblLOGINTableAdapter
            // 
            this.tblLOGINTableAdapter.ClearBeforeFill = true;
            // 
            // frmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 463);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmQuanLyNguoiDung";
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.frmQuanLyNguoiDung_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrLogin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLOGINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboQuyen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConfimMk;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private QuanlydiemDataSet25 quanlydiemDataSet25;
        private System.Windows.Forms.BindingSource tblLOGINBindingSource;
        private QuanLySinhVien.QuanlydiemDataSet25TableAdapters.tblLOGINTableAdapter tblLOGINTableAdapter;
        private Zuby.ADGV.AdvancedDataGridView dgrLogin1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyenDataGridViewTextBoxColumn1;
    }
}