using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagementSystem.Forms
{
    public partial class AdminPanelForm : Form
    {
        private MySqlConnection mySqlConnection;

        public AdminPanelForm()
        {
            InitializeComponent();            
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            mySqlConnection = new MySqlConnection(connectionString);
            try
            {
                mySqlConnection.Open();
                string query = "select * from Students";
                MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(query, mySqlConnection);
                mySqlAdapter.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                mySqlAdapter.Fill(ds, "Students");
                studentsDataGridView.DataSource = ds.Tables["Students"];
                studentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            StudentRegistrationForm studentRegistrationForm = new StudentRegistrationForm();
            studentRegistrationForm.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.ShowDialog();
            this.Close();
        }
    }
}
