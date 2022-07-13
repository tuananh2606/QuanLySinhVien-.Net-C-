using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLySinhVien.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }

        private string source = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyDiem;Integrated Security=True";
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(source))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(source))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(source))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
