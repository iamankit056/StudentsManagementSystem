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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            try
            {
                mySqlConnection.Open();
                string query = "select * from Teachers where Email=@email";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
                mySqlDataAdapter.SelectCommand.Parameters.AddWithValue("email", emailTxt.Text);
                mySqlDataAdapter.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds, "Teachers");
                
                if(ds.Tables["Teachers"].Rows.Count == 1)
                {
                    string password = (ds.Tables["Teachers"].Rows[0])["Password"].ToString();
                    if(password.CompareTo(passwordTxt.Text) == 0)
                    {
                        this.Hide();
                        AdminPanelForm adminPanelForm = new AdminPanelForm();
                        adminPanelForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        loginValidationMessageLabel.Text = "Invalid Password";
                    }
                }
                else
                {
                    loginValidationMessageLabel.Text = "Invalid Email";
                }
                
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
