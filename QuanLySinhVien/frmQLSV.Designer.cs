namespace QuanLySinhVien
{
    partial class frmQLSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrDSSV1 = new Zuby.ADGV.AdvancedDataGridView();
            this.maSvDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSINHVIENBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.quanlydiemDataSet5 = new QuanLySinhVien.QuanlydiemDataSet5();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.cboMalop = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tblSINH_VIENTableAdapter5 = new QuanLySinhVien.QuanlydiemDataSet5TableAdapters.tblSINH_VIENTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDSSV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSINHVIENBindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet5)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrDSSV1);
            this.groupBox1.Location = new System.Drawing.Point(344, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(675, 405);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgrDSSV1
            // 
            this.dgrDSSV1.AutoGenerateColumns = false;
            this.dgrDSSV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrDSSV1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrDSSV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDSSV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSvDataGridViewTextBoxColumn1,
            this.hoTenDataGridViewTextBoxColumn1,
            this.ngaySinhDataGridViewTextBoxColumn1,
            this.gioiTinhDataGridViewTextBoxColumn1,
            this.diaChiDataGridViewTextBoxColumn1,
            this.maLopDataGridViewTextBoxColumn1});
            this.dgrDSSV1.DataSource = this.tblSINHVIENBindingSource8;
            this.dgrDSSV1.FilterAndSortEnabled = true;
            this.dgrDSSV1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrDSSV1.Location = new System.Drawing.Point(0, 22);
            this.dgrDSSV1.Name = "dgrDSSV1";
            this.dgrDSSV1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgrDSSV1.RowHeadersWidth = 51;
            this.dgrDSSV1.RowTemplate.Height = 24;
            this.dgrDSSV1.Size = new System.Drawing.Size(675, 383);
            this.dgrDSSV1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrDSSV1.TabIndex = 1;
            this.dgrDSSV1.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgrDSSV1_SortStringChanged);
            this.dgrDSSV1.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgrDSSV1_FilterStringChanged);
            this.dgrDSSV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDSSV1_CellClick);
            // 
            // maSvDataGridViewTextBoxColumn1
            // 
            this.maSvDataGridViewTextBoxColumn1.DataPropertyName = "MaSv";
            this.maSvDataGridViewTextBoxColumn1.HeaderText = "MaSv";
            this.maSvDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.maSvDataGridViewTextBoxColumn1.Name = "maSvDataGridViewTextBoxColumn1";
            this.maSvDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // hoTenDataGridViewTextBoxColumn1
            // 
            this.hoTenDataGridViewTextBoxColumn1.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn1.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.hoTenDataGridViewTextBoxColumn1.Name = "hoTenDataGridViewTextBoxColumn1";
            this.hoTenDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ngaySinhDataGridViewTextBoxColumn1
            // 
            this.ngaySinhDataGridViewTextBoxColumn1.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn1.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.ngaySinhDataGridViewTextBoxColumn1.Name = "ngaySinhDataGridViewTextBoxColumn1";
            this.ngaySinhDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // gioiTinhDataGridViewTextBoxColumn1
            // 
            this.gioiTinhDataGridViewTextBoxColumn1.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn1.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.gioiTinhDataGridViewTextBoxColumn1.Name = "gioiTinhDataGridViewTextBoxColumn1";
            this.gioiTinhDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // diaChiDataGridViewTextBoxColumn1
            // 
            this.diaChiDataGridViewTextBoxColumn1.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn1.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.diaChiDataGridViewTextBoxColumn1.Name = "diaChiDataGridViewTextBoxColumn1";
            this.diaChiDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // maLopDataGridViewTextBoxColumn1
            // 
            this.maLopDataGridViewTextBoxColumn1.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn1.HeaderText = "MaLop";
            this.maLopDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.maLopDataGridViewTextBoxColumn1.Name = "maLopDataGridViewTextBoxColumn1";
            this.maLopDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tblSINHVIENBindingSource8
            // 
            this.tblSINHVIENBindingSource8.DataMember = "tblSINH_VIEN";
            this.tblSINHVIENBindingSource8.DataSource = this.quanlydiemDataSet5;
            // 
            // quanlydiemDataSet5
            // 
            this.quanlydiemDataSet5.DataSetName = "QuanlydiemDataSet5";
            this.quanlydiemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskNgaySinh);
            this.groupBox2.Controls.Add(this.cboGioiTinh);
            this.groupBox2.Controls.Add(this.cboMalop);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.txtMaSV);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(7, 106);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(329, 404);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // mskNgaySinh
            // 
            this.mskNgaySinh.Location = new System.Drawing.Point(115, 134);
            this.mskNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.mskNgaySinh.Mask = "00/00/0000";
            this.mskNgaySinh.Name = "mskNgaySinh";
            this.mskNgaySinh.Size = new System.Drawing.Size(176, 22);
            this.mskNgaySinh.TabIndex = 3;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Chưa xác định"});
            this.cboGioiTinh.Location = new System.Drawing.Point(115, 176);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(124, 24);
            this.cboGioiTinh.TabIndex = 4;
            this.cboGioiTinh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboMalop
            // 
            this.cboMalop.FormattingEnabled = true;
            this.cboMalop.Location = new System.Drawing.Point(115, 259);
            this.cboMalop.Margin = new System.Windows.Forms.Padding(4);
            this.cboMalop.Name = "cboMalop";
            this.cboMalop.Size = new System.Drawing.Size(176, 24);
            this.cboMalop.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 266);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Mã Lớp:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(115, 219);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(176, 22);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(115, 96);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(176, 22);
            this.txtHoTen.TabIndex = 2;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(115, 52);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(176, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giới  tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã sinh viên:";
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemmoi.Image")));
            this.btnThemmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemmoi.Location = new System.Drawing.Point(1041, 219);
            this.btnThemmoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(142, 43);
            this.btnThemmoi.TabIndex = 15;
            this.btnThemmoi.Text = "     Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(1041, 270);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(142, 43);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "    Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1041, 321);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(142, 43);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1041, 427);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(142, 43);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "   Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tblSINH_VIENTableAdapter5
            // 
            this.tblSINH_VIENTableAdapter5.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(367, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Thông Tin Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnXuat
            // 
            this.btnXuat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.Color.Blue;
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(1041, 372);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(142, 48);
            this.btnXuat.TabIndex = 20;
            this.btnXuat.Text = "       In Bảng \r\n    Điểm";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // frmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1232, 570);
            this.ControlBox = false;
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmQLSV";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frmQLSV_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDSSV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSINHVIENBindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private QuanlydiemDataSet5 quanlydiemDataSet5;
        private System.Windows.Forms.BindingSource tblSINHVIENBindingSource8;
        private QuanLySinhVien.QuanlydiemDataSet5TableAdapters.tblSINH_VIENTableAdapter tblSINH_VIENTableAdapter5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cboMalop;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.MaskedTextBox mskNgaySinh;
        private System.Windows.Forms.Label label1;
        private Zuby.ADGV.AdvancedDataGridView dgrDSSV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSvDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnXuat;
    }
}