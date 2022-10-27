using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace StudentsManagementSystem.Scripts
{
    internal class StudentsCRUD
    {
        private MySqlConnection conn;

        public StudentsCRUD()
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            conn = new MySqlConnection(myConnectionString);
        }

        public DataTable Read()
        {
            try
            {
                conn.Open();
                string mySqlQuery = "select * from Students";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlQuery, conn);
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds, "Students");
                mySqlDataAdapter.SelectCommand.ExecuteNonQuery();
                DataTable dt = ds.Tables[0];
                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
