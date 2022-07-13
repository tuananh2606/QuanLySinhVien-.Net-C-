namespace QuanLySinhVien
{
    partial class frmGiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiangVien));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.cboPhanloai = new System.Windows.Forms.ComboBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrDSGV1 = new Zuby.ADGV.AdvancedDataGridView();
            this.tblGIANGVIENBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.quanlydiemDataSet24 = new QuanLySinhVien.QuanlydiemDataSet24();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblGIANG_VIENTableAdapter3 = new QuanLySinhVien.QuanlydiemDataSet24TableAdapters.tblGIANG_VIENTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.maGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanLoaiGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDSGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGIANGVIENBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(317, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH GIẢNG VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskPhone);
            this.groupBox1.Controls.Add(this.cboPhanloai);
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(308, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(121, 158);
            this.mskPhone.Mask = "9999 000 000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskPhone.Size = new System.Drawing.Size(182, 27);
            this.mskPhone.TabIndex = 4;
            // 
            // cboPhanloai
            // 
            this.cboPhanloai.FormattingEnabled = true;
            this.cboPhanloai.Items.AddRange(new object[] {
            "Phòng Đào Tạo",
            "Phòng Khảo Thí",
            "Phòng CTSV"});
            this.cboPhanloai.Location = new System.Drawing.Point(121, 226);
            this.cboPhanloai.Name = "cboPhanloai";
            this.cboPhanloai.Size = new System.Drawing.Size(119, 27);
            this.cboPhanloai.TabIndex = 6;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(121, 115);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(119, 27);
            this.cboGioiTinh.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Phân loại GV:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 191);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Phone:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(121, 73);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(182, 27);
            this.txtHoTen.TabIndex = 2;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(121, 36);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(119, 27);
            this.txtMaGV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã giảng viên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrDSGV1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(323, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(474, 379);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgrDSGV1
            // 
            this.dgrDSGV1.AutoGenerateColumns = false;
            this.dgrDSGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgrDSGV1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrDSGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDSGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGVDataGridViewTextBoxColumn,
            this.tenGVDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phanLoaiGVDataGridViewTextBoxColumn});
            this.dgrDSGV1.DataSource = this.tblGIANGVIENBindingSource3;
            this.dgrDSGV1.FilterAndSortEnabled = true;
            this.dgrDSGV1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrDSGV1.Location = new System.Drawing.Point(0, 17);
            this.dgrDSGV1.Name = "dgrDSGV1";
            this.dgrDSGV1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgrDSGV1.RowHeadersWidth = 51;
            this.dgrDSGV1.RowTemplate.Height = 24;
            this.dgrDSGV1.Size = new System.Drawing.Size(474, 358);
            this.dgrDSGV1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrDSGV1.TabIndex = 1;
            this.dgrDSGV1.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgrDSGV1_SortStringChanged);
            this.dgrDSGV1.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgrDSGV1_FilterStringChanged);
            this.dgrDSGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDSGV1_CellClick);
            // 
            // tblGIANGVIENBindingSource3
            // 
            this.tblGIANGVIENBindingSource3.DataMember = "tblGIANG_VIEN";
            this.tblGIANGVIENBindingSource3.DataSource = this.quanlydiemDataSet24;
            // 
            // quanlydiemDataSet24
            // 
            this.quanlydiemDataSet24.DataSetName = "QuanlydiemDataSet24";
            this.quanlydiemDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tblGIANG_VIENTableAdapter3
            // 
            this.tblGIANG_VIENTableAdapter3.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(802, 317);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 39);
            this.button4.TabIndex = 12;
            this.button4.Text = "     Thoát ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(802, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 39);
            this.button3.TabIndex = 11;
            this.button3.Text = "   Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(802, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "    Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(802, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "       Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maGVDataGridViewTextBoxColumn
            // 
            this.maGVDataGridViewTextBoxColumn.DataPropertyName = "MaGV";
            this.maGVDataGridViewTextBoxColumn.HeaderText = "MaGV";
            this.maGVDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.maGVDataGridViewTextBoxColumn.Name = "maGVDataGridViewTextBoxColumn";
            this.maGVDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.maGVDataGridViewTextBoxColumn.Width = 83;
            // 
            // tenGVDataGridViewTextBoxColumn
            // 
            this.tenGVDataGridViewTextBoxColumn.DataPropertyName = "TenGV";
            this.tenGVDataGridViewTextBoxColumn.HeaderText = "TenGV";
            this.tenGVDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tenGVDataGridViewTextBoxColumn.Name = "tenGVDataGridViewTextBoxColumn";
            this.tenGVDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.tenGVDataGridViewTextBoxColumn.Width = 85;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.gioiTinhDataGridViewTextBoxColumn.Width = 98;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.phoneDataGridViewTextBoxColumn.Width = 81;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.emailDataGridViewTextBoxColumn.Width = 78;
            // 
            // phanLoaiGVDataGridViewTextBoxColumn
            // 
            this.phanLoaiGVDataGridViewTextBoxColumn.DataPropertyName = "PhanLoaiGV";
            this.phanLoaiGVDataGridViewTextBoxColumn.HeaderText = "PhanLoaiGV";
            this.phanLoaiGVDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.phanLoaiGVDataGridViewTextBoxColumn.Name = "phanLoaiGVDataGridViewTextBoxColumn";
            this.phanLoaiGVDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.phanLoaiGVDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 496);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGiangVien";
            this.Text = "Thông tin giảng viên ";
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDSGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGIANGVIENBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cboPhanloai;
        private QuanlydiemDataSet24 quanlydiemDataSet24;
        private System.Windows.Forms.BindingSource tblGIANGVIENBindingSource3;
        private QuanLySinhVien.QuanlydiemDataSet24TableAdapters.tblGIANG_VIENTableAdapter tblGIANG_VIENTableAdapter3;
        public System.Windows.Forms.Label label1;
        private Zuby.ADGV.AdvancedDataGridView dgrDSGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanLoaiGVDataGridViewTextBoxColumn;
    }
}