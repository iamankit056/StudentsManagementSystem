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
        
        public DataTable InsertRecord(Student student)
        {
            try
            {
                conn.Open();
                string mySqlQuery = "select * from Students";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlQuery, conn);
                MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds, "Students");
                DataRow row = ds.Tables["Students"].NewRow();
                row["RollNumber"] = student.rollNumber;
                row["Name"] = student.name;
                row["Department"] = student.department;
                row["Email"] = student.email;
                row["Password"] = student.password;
                ds.Tables["Students"].Rows.Add(row);
                mySqlDataAdapter.Update(ds, "Students");
                return ds.Tables["Students"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
                MessageBox.Show("Record Register Sucessesfully...");
            }
        }
    }
}
