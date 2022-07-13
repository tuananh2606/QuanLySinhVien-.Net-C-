using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace QuanLySinhVien
{
    public partial class frmDSThiLai : Form
    {
        public frmDSThiLai()
        {
            InitializeComponent();
        }

        private void frmDSThiLai_Load(object sender, EventArgs e)
        {
            FillDataGridView_DSSV();
        }
        public void FillDataGridView_DSSV()
        {
            string select = "Select * From [tblKET_QUA] where GhiChu=N'Thi lại'";
            dgrDSSV1.DataSource = DAO.DataProvider.Instance.ExecuteQuery(select);
            foreach (DataGridViewColumn column in dgrDSSV1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }
        private void btnXuat_Click(object sender, EventArgs e)
        {
            Thaotac.Export2Excel(dgrDSSV1);
        }

    }
}
