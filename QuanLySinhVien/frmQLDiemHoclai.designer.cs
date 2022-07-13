namespace QuanLySinhVien
{
    partial class frmQLDiemHoclai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLDiemHoclai));
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
            this.txtDiemThi3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgrDiem1 = new Zuby.ADGV.AdvancedDataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKETQUA3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlydiemDataSet48 = new QuanLySinhVien.QuanlydiemDataSet48();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tblKET_QUA3TableAdapter1 = new QuanLySinhVien.QuanlydiemDataSet48TableAdapters.tblKET_QUA3TableAdapter();
            this.btnXuat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDiem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKETQUA3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐIỂM HỌC LẠI";
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
            this.groupBox1.Location = new System.Drawing.Point(21, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(79, 117);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(298, 27);
            this.cboMonHoc.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 120);
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
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            ""});
            this.cboHocKi.Location = new System.Drawing.Point(300, 72);
            this.cboHocKi.Name = "cboHocKi";
            this.cboHocKi.Size = new System.Drawing.Size(77, 27);
            this.cboHocKi.TabIndex = 3;
            this.cboHocKi.SelectedIndexChanged += new System.EventHandler(this.cboHocKi_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Học kì:";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(79, 72);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(131, 27);
            this.cboLop.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lớp:";
            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.FormattingEnabled = true;
            this.cboKhoaHoc.Location = new System.Drawing.Point(79, 24);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(298, 27);
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
            this.groupBox2.Controls.Add(this.txtDiemThi3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMaSV);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(21, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 108);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtDiemThi3
            // 
            this.txtDiemThi3.Location = new System.Drawing.Point(671, 35);
            this.txtDiemThi3.Name = "txtDiemThi3";
            this.txtDiemThi3.Size = new System.Drawing.Size(65, 26);
            this.txtDiemThi3.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(563, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "Điểm học lại:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(329, 36);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(222, 26);
            this.txtHoTen.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Họ và tên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(111, 36);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(112, 26);
            this.txtMaSV.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã sinh viên:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgrDiem1);
            this.groupBox4.Location = new System.Drawing.Point(21, 317);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(742, 158);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dgrDiem1
            // 
            this.dgrDiem1.AutoGenerateColumns = false;
            this.dgrDiem1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrDiem1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrDiem1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDiem1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgrDiem1.DataSource = this.tblKETQUA3BindingSource;
            this.dgrDiem1.FilterAndSortEnabled = true;
            this.dgrDiem1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrDiem1.Location = new System.Drawing.Point(0, 25);
            this.dgrDiem1.Name = "dgrDiem1";
            this.dgrDiem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgrDiem1.RowHeadersWidth = 51;
            this.dgrDiem1.RowTemplate.Height = 24;
            this.dgrDiem1.Size = new System.Drawing.Size(742, 133);
            this.dgrDiem1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrDiem1.TabIndex = 1;
            this.dgrDiem1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDiem1_CellClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MaSV";
            this.dataGridViewTextBoxColumn7.HeaderText = "MaSV";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn8.HeaderText = "HoTen";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MaLop";
            this.dataGridViewTextBoxColumn9.HeaderText = "MaLop";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TenMon";
            this.dataGridViewTextBoxColumn10.HeaderText = "TenMon";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DiemHocLai";
            this.dataGridViewTextBoxColumn11.HeaderText = "DiemHocLai";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "HocKi";
            this.dataGridViewTextBoxColumn12.HeaderText = "HocKi";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tblKETQUA3BindingSource
            // 
            this.tblKETQUA3BindingSource.DataMember = "tblKET_QUA3";
            this.tblKETQUA3BindingSource.DataSource = this.quanlydiemDataSet48;
            // 
            // quanlydiemDataSet48
            // 
            this.quanlydiemDataSet48.DataSetName = "QuanlydiemDataSet48";
            this.quanlydiemDataSet48.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(769, 373);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 39);
            this.button4.TabIndex = 8;
            this.button4.Text = "     Thoát ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(769, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 39);
            this.button3.TabIndex = 7;
            this.button3.Text = "   Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(769, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "   Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(769, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "     Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblKET_QUA3TableAdapter1
            // 
            this.tblKET_QUA3TableAdapter1.ClearBeforeFill = true;
            // 
            // btnXuat
            // 
            this.btnXuat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.Color.Blue;
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(769, 418);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(92, 37);
            this.btnXuat.TabIndex = 12;
            this.btnXuat.Text = "      In BĐ";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // frmQLDiemHoclai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 492);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQLDiemHoclai";
            this.Text = "Nhập điểm sinh viên";
            this.Load += new System.EventHandler(this.frmQLDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDiem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKETQUA3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtDiemThi3;
        private System.Windows.Forms.Label label10;
        //private QuanlydiemDataSet49 quanlydiemDataSet49;
        //private Quản_lý_điểm_sinh_vien_CNTT.QuanlydiemDataSet49TableAdapters.tblKET_QUA3TableAdapter tblKET_QUA3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemHocLaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKiDataGridViewTextBoxColumn;
        private QuanlydiemDataSet48 quanlydiemDataSet48;
        private System.Windows.Forms.BindingSource tblKETQUA3BindingSource;
        private QuanLySinhVien.QuanlydiemDataSet48TableAdapters.tblKET_QUA3TableAdapter tblKET_QUA3TableAdapter1;
        private System.Windows.Forms.Button btnXuat;
        private Zuby.ADGV.AdvancedDataGridView dgrDiem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}