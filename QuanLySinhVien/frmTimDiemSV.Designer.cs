namespace QuanLySinhVien
{
    partial class frmTimDiemSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimDiemSV));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrDIEMSV1 = new Zuby.ADGV.AdvancedDataGridView();
            this.maSVDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemThiLan1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemThiLan2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTongKetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanhKiemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocKiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKETQUABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlydiemDataSet49 = new QuanLySinhVien.QuanlydiemDataSet49();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblKET_QUATableAdapter = new QuanLySinhVien.QuanlydiemDataSet49TableAdapters.tblKET_QUATableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDIEMSV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKETQUABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet49)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(345, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN ĐIỂM SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrDIEMSV1);
            this.groupBox1.Location = new System.Drawing.Point(33, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 383);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // dgrDIEMSV1
            // 
            this.dgrDIEMSV1.AutoGenerateColumns = false;
            this.dgrDIEMSV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgrDIEMSV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDIEMSV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn1,
            this.hoTenDataGridViewTextBoxColumn1,
            this.maLopDataGridViewTextBoxColumn1,
            this.maMonDataGridViewTextBoxColumn1,
            this.diemTBDataGridViewTextBoxColumn1,
            this.diemThiLan1DataGridViewTextBoxColumn1,
            this.diemThiLan2DataGridViewTextBoxColumn1,
            this.diemTongKetDataGridViewTextBoxColumn1,
            this.hanhKiemDataGridViewTextBoxColumn1,
            this.hocKiDataGridViewTextBoxColumn1,
            this.ghiChuDataGridViewTextBoxColumn1});
            this.dgrDIEMSV1.DataSource = this.tblKETQUABindingSource;
            this.dgrDIEMSV1.FilterAndSortEnabled = true;
            this.dgrDIEMSV1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrDIEMSV1.Location = new System.Drawing.Point(0, 25);
            this.dgrDIEMSV1.Name = "dgrDIEMSV1";
            this.dgrDIEMSV1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgrDIEMSV1.RowHeadersWidth = 51;
            this.dgrDIEMSV1.RowTemplate.Height = 24;
            this.dgrDIEMSV1.Size = new System.Drawing.Size(631, 358);
            this.dgrDIEMSV1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrDIEMSV1.TabIndex = 1;
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
            this.diemTBDataGridViewTextBoxColumn1.DataPropertyName = "DiemTB";
            this.diemTBDataGridViewTextBoxColumn1.HeaderText = "DiemTB";
            this.diemTBDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.diemTBDataGridViewTextBoxColumn1.Name = "diemTBDataGridViewTextBoxColumn1";
            this.diemTBDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.diemTBDataGridViewTextBoxColumn1.Width = 96;
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
            // diemThiLan2DataGridViewTextBoxColumn1
            // 
            this.diemThiLan2DataGridViewTextBoxColumn1.DataPropertyName = "DiemThiLan2";
            this.diemThiLan2DataGridViewTextBoxColumn1.HeaderText = "DiemThiLan2";
            this.diemThiLan2DataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.diemThiLan2DataGridViewTextBoxColumn1.Name = "diemThiLan2DataGridViewTextBoxColumn1";
            this.diemThiLan2DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.diemThiLan2DataGridViewTextBoxColumn1.Width = 132;
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
            // tblKETQUABindingSource
            // 
            this.tblKETQUABindingSource.DataMember = "tblKET_QUA";
            this.tblKETQUABindingSource.DataSource = this.quanlydiemDataSet49;
            // 
            // quanlydiemDataSet49
            // 
            this.quanlydiemDataSet49.DataSetName = "QuanlydiemDataSet49";
            this.quanlydiemDataSet49.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboMonHoc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaSV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(680, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 116);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiêm";
            // 
            // btnXuat
            // 
            this.btnXuat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.Color.Blue;
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(761, 329);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(149, 42);
            this.btnXuat.TabIndex = 11;
            this.btnXuat.Text = "       In Bảng Điểm";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Blue;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(761, 377);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(149, 41);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Blue;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(761, 284);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(149, 39);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "   Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(111, 66);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(145, 27);
            this.cboMonHoc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Môn học:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(111, 34);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(145, 26);
            this.txtMaSV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tblKET_QUATableAdapter
            // 
            this.tblKET_QUATableAdapter.ClearBeforeFill = true;
            // 
            // frmTimDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 499);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTimDiemSV";
            this.Text = "Tra cứu điểm sinh viên";
            this.Load += new System.EventHandler(this.frmTimDiemSV_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDIEMSV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKETQUABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet49)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuat;
        private QuanlydiemDataSet49 quanlydiemDataSet49;
        private System.Windows.Forms.BindingSource tblKETQUABindingSource;
        private QuanLySinhVien.QuanlydiemDataSet49TableAdapters.tblKET_QUATableAdapter tblKET_QUATableAdapter;
        private Zuby.ADGV.AdvancedDataGridView dgrDIEMSV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTBDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemThiLan1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemThiLan2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTongKetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanhKiemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn1;
    }
}