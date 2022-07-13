namespace QuanLySinhVien
{
    partial class frmKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoa));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tblKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlydiemDataSet50 = new QuanLySinhVien.QuanlydiemDataSet50();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tblKHOATableAdapter = new QuanLySinhVien.QuanlydiemDataSet50TableAdapters.tblKHOATableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgrKhoa1 = new Zuby.ADGV.AdvancedDataGridView();
            this.maKhoaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhoaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrKhoa1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(402, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHOA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKhoa);
            this.groupBox1.Controls.Add(this.txtTenKhoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 423);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // txtKhoa
            // 
            this.txtKhoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoa.Location = new System.Drawing.Point(100, 46);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(179, 26);
            this.txtKhoa.TabIndex = 1;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoa.Location = new System.Drawing.Point(100, 89);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(179, 26);
            this.txtTenKhoa.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên khoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khoa:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrKhoa1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(335, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 423);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // tblKHOABindingSource
            // 
            this.tblKHOABindingSource.DataMember = "tblKHOA";
            this.tblKHOABindingSource.DataSource = this.quanlydiemDataSet50;
            // 
            // quanlydiemDataSet50
            // 
            this.quanlydiemDataSet50.DataSetName = "QuanlydiemDataSet50";
            this.quanlydiemDataSet50.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(12, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 39);
            this.button4.TabIndex = 16;
            this.button4.Text = "    Thoát ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 39);
            this.button3.TabIndex = 15;
            this.button3.Text = "    Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 39);
            this.button2.TabIndex = 14;
            this.button2.Text = "    Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "      Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblKHOATableAdapter
            // 
            this.tblKHOATableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(803, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 201);
            this.panel1.TabIndex = 17;
            // 
            // dgrKhoa1
            // 
            this.dgrKhoa1.AutoGenerateColumns = false;
            this.dgrKhoa1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrKhoa1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrKhoa1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrKhoa1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhoaDataGridViewTextBoxColumn1,
            this.tenKhoaDataGridViewTextBoxColumn1});
            this.dgrKhoa1.DataSource = this.tblKHOABindingSource;
            this.dgrKhoa1.FilterAndSortEnabled = true;
            this.dgrKhoa1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrKhoa1.Location = new System.Drawing.Point(0, 25);
            this.dgrKhoa1.Name = "dgrKhoa1";
            this.dgrKhoa1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgrKhoa1.RowHeadersWidth = 51;
            this.dgrKhoa1.RowTemplate.Height = 24;
            this.dgrKhoa1.Size = new System.Drawing.Size(462, 398);
            this.dgrKhoa1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgrKhoa1.TabIndex = 1;
            this.dgrKhoa1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrKhoa1_CellClick);
            // 
            // maKhoaDataGridViewTextBoxColumn1
            // 
            this.maKhoaDataGridViewTextBoxColumn1.DataPropertyName = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn1.HeaderText = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.maKhoaDataGridViewTextBoxColumn1.Name = "maKhoaDataGridViewTextBoxColumn1";
            this.maKhoaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tenKhoaDataGridViewTextBoxColumn1
            // 
            this.tenKhoaDataGridViewTextBoxColumn1.DataPropertyName = "TenKhoa";
            this.tenKhoaDataGridViewTextBoxColumn1.HeaderText = "TenKhoa";
            this.tenKhoaDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.tenKhoaDataGridViewTextBoxColumn1.Name = "tenKhoaDataGridViewTextBoxColumn1";
            this.tenKhoaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // frmKhoa
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
            this.Name = "frmKhoa";
            this.Text = "Quản lý khoa";
            this.Load += new System.EventHandler(this.frmLop_Khoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblKHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydiemDataSet50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrKhoa1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtKhoa;
        private QuanlydiemDataSet50 quanlydiemDataSet50;
        private System.Windows.Forms.BindingSource tblKHOABindingSource;
        private QuanLySinhVien.QuanlydiemDataSet50TableAdapters.tblKHOATableAdapter tblKHOATableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Zuby.ADGV.AdvancedDataGridView dgrKhoa1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoaDataGridViewTextBoxColumn1;
    }
}