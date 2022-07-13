namespace QuanLySinhVien
{
    partial class frmMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrMON1 = new Zuby.ADGV.AdvancedDataGridView();
            this.tblMONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlydiemDataSet52 = new QuanLySinhVien.QuanlydiemDataSet52();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblMONTableAdapter = new QuanLySinhVien.QuanlydiemDataSet52TableAdapters.tblMONTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maMonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGVDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocKiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMON1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH MÔN HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboKhoa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHocKy);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenMon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaMon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(262, 411);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(106, 197);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(145, 27);
            this.cboKhoa.TabIndex = 23;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoaHoc_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mã khoa:";
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(106, 152);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(145, 26);
            this.txtHocKy.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Học kỳ:";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(106, 110);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(145, 26);
            this.txtMaGV.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Giảng viên:";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(106, 67);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(145, 26);
            this.txtTenMon.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên môn:";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(106, 25);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(145, 26);
            this.txtMaMon.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã môn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrMON1);
            this.groupBox2.Location = new System.Drawing.Point(278, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 411);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgrMON1
            // 
            this.dgrMON1.AutoGenerateColumns = false;
            this.dgrMON1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgrMON1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrMON1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrMON1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonDataGridViewTextBoxColumn1,
            this.tenMonDataGridViewTextBoxColumn1,
            this.maGVDataGridViewTextBoxColumn1,
            this.hocKiDataGridViewTextBoxColumn1,
            this.maKhoaDataGridViewTextBoxColumn1});
            this.dgrMON1.DataSource = this.tblMONBindingSource;
            this.dgrMON1.FilterAndSortEnabled = true;
            this.dgrMON1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrMON1.Location = new System.Drawing.Point(0, 25);
            this.dgrMON1.Name = "dgrMON1";
            this.dgrMON1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgrMON1.RowHeadersWidth = 51;
            this.dgrMON1.RowTemplate.Height = 24;
            this.dgrMON1.Size = new System.Drawing.Size(518, 386);
            this.dgrMON1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrMON1.TabIndex = 1;
            this.dgrMON1.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgrMON1_SortStringChanged);
            this.dgrMON1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrMON1_CellClick);
            // 
            // tblMONBindingSource
            // 
            this.tblMONBindingSource.DataMember = "tblMON";
            this.tblMONBindingSource.DataSource = this.quanlydiemDataSet52;
            // 
            // quanlydiemDataSet52
            // 
            this.quanlydiemDataSet52.DataSetName = "QuanlydiemDataSet52";
            this.quanlydiemDataSet52.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(13, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 39);
            this.button4.TabIndex = 12;
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
            this.button3.Location = new System.Drawing.Point(13, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 39);
            this.button3.TabIndex = 11;
            this.button3.Text = "    Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(13, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "     Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "       Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tblMONTableAdapter
            // 
            this.tblMONTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(802, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 205);
            this.panel1.TabIndex = 13;
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
            // tenMonDataGridViewTextBoxColumn1
            // 
            this.tenMonDataGridViewTextBoxColumn1.DataPropertyName = "TenMon";
            this.tenMonDataGridViewTextBoxColumn1.HeaderText = "TenMon";
            this.tenMonDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.tenMonDataGridViewTextBoxColumn1.Name = "tenMonDataGridViewTextBoxColumn1";
            this.tenMonDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.tenMonDataGridViewTextBoxColumn1.Width = 94;
            // 
            // maGVDataGridViewTextBoxColumn1
            // 
            this.maGVDataGridViewTextBoxColumn1.DataPropertyName = "MaGV";
            this.maGVDataGridViewTextBoxColumn1.HeaderText = "MaGV";
            this.maGVDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.maGVDataGridViewTextBoxColumn1.Name = "maGVDataGridViewTextBoxColumn1";
            this.maGVDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.maGVDataGridViewTextBoxColumn1.Width = 83;
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
            // maKhoaDataGridViewTextBoxColumn1
            // 
            this.maKhoaDataGridViewTextBoxColumn1.DataPropertyName = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn1.HeaderText = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.maKhoaDataGridViewTextBoxColumn1.Name = "maKhoaDataGridViewTextBoxColumn1";
            this.maKhoaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.maKhoaDataGridViewTextBoxColumn1.Width = 96;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 487);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMonHoc";
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrMON1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private QuanlydiemDataSet52 quanlydiemDataSet52;
        private System.Windows.Forms.BindingSource tblMONBindingSource;
        private QuanLySinhVien.QuanlydiemDataSet52TableAdapters.tblMONTableAdapter tblMONTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Zuby.ADGV.AdvancedDataGridView dgrMON1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGVDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoaDataGridViewTextBoxColumn1;
    }
}