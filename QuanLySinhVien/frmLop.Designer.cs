namespace QuanLySinhVien
{
    partial class frmLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrLop1 = new Zuby.ADGV.AdvancedDataGridView();
            this.maKhoaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlydiemDataSet37 = new QuanLySinhVien.QuanlydiemDataSet37();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenlop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblLOPTableAdapter = new QuanLySinhVien.QuanlydiemDataSet37TableAdapters.tblLOPTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblLOPTableAdapter1 = new QuanLySinhVien.QuanLyLop1DataSetTableAdapters.tblLOPTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrLop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet37)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrLop1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(300, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 423);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgrLop1
            // 
            this.dgrLop1.AutoGenerateColumns = false;
            this.dgrLop1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrLop1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrLop1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhoaDataGridViewTextBoxColumn1,
            this.maLopDataGridViewTextBoxColumn1,
            this.tenLopDataGridViewTextBoxColumn1});
            this.dgrLop1.DataSource = this.tblLOPBindingSource;
            this.dgrLop1.FilterAndSortEnabled = true;
            this.dgrLop1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrLop1.Location = new System.Drawing.Point(0, 22);
            this.dgrLop1.Name = "dgrLop1";
            this.dgrLop1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgrLop1.RowHeadersWidth = 51;
            this.dgrLop1.RowTemplate.Height = 24;
            this.dgrLop1.Size = new System.Drawing.Size(442, 401);
            this.dgrLop1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrLop1.TabIndex = 1;
            this.dgrLop1.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dgrLop1_FilterStringChanged);
            this.dgrLop1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrLop1_CellClick);
            // 
            // maKhoaDataGridViewTextBoxColumn1
            // 
            this.maKhoaDataGridViewTextBoxColumn1.DataPropertyName = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn1.FillWeight = 96.40103F;
            this.maKhoaDataGridViewTextBoxColumn1.HeaderText = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.maKhoaDataGridViewTextBoxColumn1.Name = "maKhoaDataGridViewTextBoxColumn1";
            this.maKhoaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.maKhoaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // maLopDataGridViewTextBoxColumn1
            // 
            this.maLopDataGridViewTextBoxColumn1.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn1.FillWeight = 100.4317F;
            this.maLopDataGridViewTextBoxColumn1.HeaderText = "MaLop";
            this.maLopDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.maLopDataGridViewTextBoxColumn1.Name = "maLopDataGridViewTextBoxColumn1";
            this.maLopDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.maLopDataGridViewTextBoxColumn1.Width = 130;
            // 
            // tenLopDataGridViewTextBoxColumn1
            // 
            this.tenLopDataGridViewTextBoxColumn1.DataPropertyName = "TenLop";
            this.tenLopDataGridViewTextBoxColumn1.FillWeight = 103.1672F;
            this.tenLopDataGridViewTextBoxColumn1.HeaderText = "TenLop";
            this.tenLopDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.tenLopDataGridViewTextBoxColumn1.Name = "tenLopDataGridViewTextBoxColumn1";
            this.tenLopDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.tenLopDataGridViewTextBoxColumn1.Width = 134;
            // 
            // tblLOPBindingSource
            // 
            this.tblLOPBindingSource.DataMember = "tblLOP";
            this.tblLOPBindingSource.DataSource = this.quanlydiemDataSet37;
            // 
            // quanlydiemDataSet37
            // 
            this.quanlydiemDataSet37.DataSetName = "QuanlydiemDataSet37";
            this.quanlydiemDataSet37.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cboKhoa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.txtTenlop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 397);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(108, 144);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(156, 27);
            this.cboKhoa.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã khoa:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(108, 46);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(156, 26);
            this.txtMaLop.TabIndex = 1;
            // 
            // txtTenlop
            // 
            this.txtTenlop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenlop.Location = new System.Drawing.Point(108, 96);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Size = new System.Drawing.Size(156, 26);
            this.txtTenlop.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(394, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "QUẢN LÝ LỚP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(11, 143);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 39);
            this.button4.TabIndex = 23;
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
            this.button3.Location = new System.Drawing.Point(11, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 39);
            this.button3.TabIndex = 22;
            this.button3.Text = "   Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(11, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 39);
            this.button2.TabIndex = 21;
            this.button2.Text = "   Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(11, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 20;
            this.button1.Text = "      Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tblLOPTableAdapter
            // 
            this.tblLOPTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(798, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 216);
            this.panel1.TabIndex = 24;
            // 
            // tblLOPTableAdapter1
            // 
            this.tblLOPTableAdapter1.ClearBeforeFill = true;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 495);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLop";
            this.Text = "Quản lý lớp học";
            this.Load += new System.EventHandler(this.frmLop_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrLop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet37)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenlop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private QuanlydiemDataSet37 quanlydiemDataSet37;
        private System.Windows.Forms.BindingSource tblLOPBindingSource;
        private QuanLySinhVien.QuanlydiemDataSet37TableAdapters.tblLOPTableAdapter tblLOPTableAdapter;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Panel panel1;
        private Zuby.ADGV.AdvancedDataGridView dgrLop1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopDataGridViewTextBoxColumn1;
        private QuanLyLop1DataSetTableAdapters.tblLOPTableAdapter tblLOPTableAdapter1;
    }
}