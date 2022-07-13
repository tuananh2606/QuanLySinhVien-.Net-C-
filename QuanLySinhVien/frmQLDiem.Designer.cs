namespace QuanLySinhVien
{
    partial class frmQLDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLDiem));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboHocKi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboKhoaHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiemQT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboHanhKiem = new System.Windows.Forms.ComboBox();
            this.txtDiemThi1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDiemTK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgrDiem1 = new Zuby.ADGV.AdvancedDataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.tblKETQUABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlydiemDataSet47 = new QuanLySinhVien.QuanlydiemDataSet47();
            this.tblKET_QUATableAdapter = new QuanLySinhVien.QuanlydiemDataSet47TableAdapters.tblKET_QUATableAdapter();
            this.maSVDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemThiLan1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTongKetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanhKiemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocKiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDiem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKETQUABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet47)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(259, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN ĐIỂM SINH VIÊN ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMonHoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboHocKi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboKhoaHoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(79, 107);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(222, 27);
            this.cboMonHoc.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Môn học:";
            // 
            // cboHocKi
            // 
            this.cboHocKi.FormattingEnabled = true;
            this.cboHocKi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboHocKi.Location = new System.Drawing.Point(294, 64);
            this.cboHocKi.Name = "cboHocKi";
            this.cboHocKi.Size = new System.Drawing.Size(83, 27);
            this.cboHocKi.TabIndex = 3;
            this.cboHocKi.SelectedIndexChanged += new System.EventHandler(this.cboHocKi_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Học kì:";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(79, 64);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(131, 27);
            this.cboLop.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lớp:";
            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.FormattingEnabled = true;
            this.cboKhoaHoc.Location = new System.Drawing.Point(79, 20);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(192, 27);
            this.cboKhoaHoc.TabIndex = 1;
            this.cboKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cboKhoaHoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khoa:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDiemQT);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cboHanhKiem);
            this.groupBox2.Controls.Add(this.txtDiemThi1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtDiemTK);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMaSV);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(21, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 106);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Điểm QT:";
            // 
            // txtDiemQT
            // 
            this.txtDiemQT.Location = new System.Drawing.Point(89, 71);
            this.txtDiemQT.Name = "txtDiemQT";
            this.txtDiemQT.Size = new System.Drawing.Size(72, 26);
            this.txtDiemQT.TabIndex = 8;
            this.txtDiemQT.TextChanged += new System.EventHandler(this.txtDiemTB_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(546, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 19);
            this.label13.TabIndex = 23;
            this.label13.Text = "Hạnh kiểm:";
            // 
            // cboHanhKiem
            // 
            this.cboHanhKiem.FormattingEnabled = true;
            this.cboHanhKiem.Items.AddRange(new object[] {
            "Kém",
            "Yếu",
            "Trung bình",
            "Khá ",
            "Tốt"});
            this.cboHanhKiem.Location = new System.Drawing.Point(634, 25);
            this.cboHanhKiem.Name = "cboHanhKiem";
            this.cboHanhKiem.Size = new System.Drawing.Size(98, 27);
            this.cboHanhKiem.TabIndex = 7;
            // 
            // txtDiemThi1
            // 
            this.txtDiemThi1.Location = new System.Drawing.Point(348, 71);
            this.txtDiemThi1.Name = "txtDiemThi1";
            this.txtDiemThi1.Size = new System.Drawing.Size(80, 26);
            this.txtDiemThi1.TabIndex = 9;
            this.txtDiemThi1.TextChanged += new System.EventHandler(this.txtDiemThi1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(236, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "Điểm thi lần 1:";
            // 
            // txtDiemTK
            // 
            this.txtDiemTK.Location = new System.Drawing.Point(589, 71);
            this.txtDiemTK.Name = "txtDiemTK";
            this.txtDiemTK.Size = new System.Drawing.Size(70, 26);
            this.txtDiemTK.TabIndex = 11;
            this.txtDiemTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemTK_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(477, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Điểm tổng kết:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(315, 25);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(212, 26);
            this.txtHoTen.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Họ và tên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(106, 25);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(104, 26);
            this.txtMaSV.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã sinh viên:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtGhiChu);
            this.groupBox3.Location = new System.Drawing.Point(419, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 141);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(6, 20);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(333, 105);
            this.txtGhiChu.TabIndex = 12;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgrDiem1);
            this.groupBox4.Location = new System.Drawing.Point(21, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(742, 220);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dgrDiem1
            // 
            this.dgrDiem1.AutoGenerateColumns = false;
            this.dgrDiem1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgrDiem1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrDiem1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDiem1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn1,
            this.hoTenDataGridViewTextBoxColumn1,
            this.maLopDataGridViewTextBoxColumn1,
            this.maMonDataGridViewTextBoxColumn1,
            this.diemTBDataGridViewTextBoxColumn1,
            this.diemThiLan1DataGridViewTextBoxColumn1,
            this.diemTongKetDataGridViewTextBoxColumn1,
            this.hanhKiemDataGridViewTextBoxColumn1,
            this.hocKiDataGridViewTextBoxColumn1,
            this.ghiChuDataGridViewTextBoxColumn1});
            this.dgrDiem1.DataSource = this.tblKETQUABindingSource;
            this.dgrDiem1.FilterAndSortEnabled = true;
            this.dgrDiem1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrDiem1.Location = new System.Drawing.Point(0, 23);
            this.dgrDiem1.Name = "dgrDiem1";
            this.dgrDiem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgrDiem1.RowHeadersWidth = 51;
            this.dgrDiem1.RowTemplate.Height = 24;
            this.dgrDiem1.Size = new System.Drawing.Size(742, 197);
            this.dgrDiem1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrDiem1.TabIndex = 1;
            this.dgrDiem1.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgrDiem1_FilterStringChanged);
            this.dgrDiem1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDiem1_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(801, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 39);
            this.button4.TabIndex = 8;
            this.button4.Text = "      Thoát ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(801, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 39);
            this.button3.TabIndex = 7;
            this.button3.Text = "     Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(801, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "     Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(801, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "       Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.Color.Blue;
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(780, 398);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(132, 59);
            this.btnXuat.TabIndex = 12;
            this.btnXuat.Text = "      In Bảng \r\n    Điểm";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // tblKETQUABindingSource
            // 
            this.tblKETQUABindingSource.DataMember = "tblKET_QUA";
            this.tblKETQUABindingSource.DataSource = this.quanlydiemDataSet47;
            // 
            // quanlydiemDataSet47
            // 
            this.quanlydiemDataSet47.DataSetName = "QuanlydiemDataSet47";
            this.quanlydiemDataSet47.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKET_QUATableAdapter
            // 
            this.tblKET_QUATableAdapter.ClearBeforeFill = true;
            // 
            // maSVDataGridViewTextBoxColumn1
            // 
            this.maSVDataGridViewTextBoxColumn1.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn1.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.maSVDataGridViewTextBoxColumn1.Name = "maSVDataGridViewTextBoxColumn1";
            this.maSVDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.maSVDataGridViewTextBoxColumn1.Width = 80;
            // 
            // hoTenDataGridViewTextBoxColumn1
            // 
            this.hoTenDataGridViewTextBoxColumn1.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn1.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.hoTenDataGridViewTextBoxColumn1.Name = "hoTenDataGridViewTextBoxColumn1";
            this.hoTenDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.hoTenDataGridViewTextBoxColumn1.Width = 83;
            // 
            // maLopDataGridViewTextBoxColumn1
            // 
            this.maLopDataGridViewTextBoxColumn1.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn1.HeaderText = "MaLop";
            this.maLopDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.maLopDataGridViewTextBoxColumn1.Name = "maLopDataGridViewTextBoxColumn1";
            this.maLopDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.maLopDataGridViewTextBoxColumn1.Width = 87;
            // 
            // maMonDataGridViewTextBoxColumn1
            // 
            this.maMonDataGridViewTextBoxColumn1.DataPropertyName = "MaMon";
            this.maMonDataGridViewTextBoxColumn1.HeaderText = "MaMon";
            this.maMonDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.maMonDataGridViewTextBoxColumn1.Name = "maMonDataGridViewTextBoxColumn1";
            this.maMonDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.maMonDataGridViewTextBoxColumn1.Width = 92;
            // 
            // diemTBDataGridViewTextBoxColumn1
            // 
            this.diemTBDataGridViewTextBoxColumn1.DataPropertyName = "DiemQT";
            this.diemTBDataGridViewTextBoxColumn1.HeaderText = "DiemQT";
            this.diemTBDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.diemTBDataGridViewTextBoxColumn1.Name = "diemTBDataGridViewTextBoxColumn1";
            this.diemTBDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.diemTBDataGridViewTextBoxColumn1.Width = 97;
            // 
            // diemThiLan1DataGridViewTextBoxColumn1
            // 
            this.diemThiLan1DataGridViewTextBoxColumn1.DataPropertyName = "DiemThiLan1";
            this.diemThiLan1DataGridViewTextBoxColumn1.HeaderText = "DiemThiLan1";
            this.diemThiLan1DataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.diemThiLan1DataGridViewTextBoxColumn1.Name = "diemThiLan1DataGridViewTextBoxColumn1";
            this.diemThiLan1DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.diemThiLan1DataGridViewTextBoxColumn1.Width = 132;
            // 
            // diemTongKetDataGridViewTextBoxColumn1
            // 
            this.diemTongKetDataGridViewTextBoxColumn1.DataPropertyName = "DiemTongKet";
            this.diemTongKetDataGridViewTextBoxColumn1.HeaderText = "DiemTongKet";
            this.diemTongKetDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.diemTongKetDataGridViewTextBoxColumn1.Name = "diemTongKetDataGridViewTextBoxColumn1";
            this.diemTongKetDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.diemTongKetDataGridViewTextBoxColumn1.Width = 134;
            // 
            // hanhKiemDataGridViewTextBoxColumn1
            // 
            this.hanhKiemDataGridViewTextBoxColumn1.DataPropertyName = "HanhKiem";
            this.hanhKiemDataGridViewTextBoxColumn1.HeaderText = "HanhKiem";
            this.hanhKiemDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.hanhKiemDataGridViewTextBoxColumn1.Name = "hanhKiemDataGridViewTextBoxColumn1";
            this.hanhKiemDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.hanhKiemDataGridViewTextBoxColumn1.Width = 111;
            // 
            // hocKiDataGridViewTextBoxColumn1
            // 
            this.hocKiDataGridViewTextBoxColumn1.DataPropertyName = "HocKi";
            this.hocKiDataGridViewTextBoxColumn1.HeaderText = "HocKi";
            this.hocKiDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.hocKiDataGridViewTextBoxColumn1.Name = "hocKiDataGridViewTextBoxColumn1";
            this.hocKiDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.hocKiDataGridViewTextBoxColumn1.Width = 84;
            // 
            // ghiChuDataGridViewTextBoxColumn1
            // 
            this.ghiChuDataGridViewTextBoxColumn1.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn1.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.ghiChuDataGridViewTextBoxColumn1.Name = "ghiChuDataGridViewTextBoxColumn1";
            this.ghiChuDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ghiChuDataGridViewTextBoxColumn1.Width = 90;
            // 
            // frmQLDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 540);
            this.ControlBox = false;
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmQLDiem";
            this.Text = "Nhập điểm sinh viên";
            this.Load += new System.EventHandler(this.frmQLDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDiem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKETQUABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet47)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboKhoaHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboHocKi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiemThi1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDiemTK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboHanhKiem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtDiemQT;
        private System.Windows.Forms.Label label3;
        private QuanlydiemDataSet47 quanlydiemDataSet47;
        private System.Windows.Forms.BindingSource tblKETQUABindingSource;
        private QuanLySinhVien.QuanlydiemDataSet47TableAdapters.tblKET_QUATableAdapter tblKET_QUATableAdapter;
        private System.Windows.Forms.Button btnXuat;
        private Zuby.ADGV.AdvancedDataGridView dgrDiem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTBDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemThiLan1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTongKetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanhKiemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn1;
    }
}