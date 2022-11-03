using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagementSystem.Forms
{
    public partial class StudentRegistrationForm : Form
    {
        MySqlConnection mySqlConnection;

        public StudentRegistrationForm(MySqlConnection mySqlConnection)
        {
            InitializeComponent();
            this.mySqlConnection = mySqlConnection;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool isErrorOccure = Validation();
            if (!isErrorOccure)
            {
                try
                {
                    mySqlConnection.Open();
                    string query = "select * from Students";
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
                    MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);
                    DataSet ds = new DataSet();
                    mySqlDataAdapter.Fill(ds, "Students");
                    DataRow row = ds.Tables["Students"].NewRow();

                    row["Name"] = nameTxt.Text;
                    row["Email"] = emailTxt.Text;
                    row["Password"] = passwordTxt.Text;
                    row["RollNumber"] = Convert.ToInt32(rollNumberTxt.Text);
                    row["Department"] = departmentCBox.SelectedItem;

                    ds.Tables["Students"].Rows.Add(row);
                    mySqlDataAdapter.Update(ds, "Students");
                    MessageBox.Show("Record inserted sucessesfully");
                    ResetForm();
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
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // Validate Registration Form
        private bool Validation()
        {
            bool isErrorOccure = false;

            if (nameTxt.Text == "")
            {
                isErrorOccure = true;
                nameValidationLabel.Visible = true;
            }
            
            if (rollNumberTxt.Text == "")
            {
                isErrorOccure = true;
                rollNumberValidationLabel.Visible = true;
            }

            if (emailTxt.Text == "")
            {
                isErrorOccure = true;
                emailValidationLabel.Visible = true;
            }

            if (passwordTxt.Text == "")
            {
                isErrorOccure= true;
                passwordValidationLabel.Visible = true;
            }

            if(conformPasswordTxt.Text.CompareTo(passwordTxt.Text) > 0)
            {
                isErrorOccure = true;
                conformPasswordValidationLabel.Visible = true;
            }

            return isErrorOccure;
        }

        private void ResetForm()
        {
            // clear all input fields
            nameTxt.Text = "";
            rollNumberTxt.Text = "";
            departmentCBox.SelectedItem = null;
            emailTxt.Text = "";
            passwordTxt.Text = "";
            conformPasswordTxt.Text = "";

            // clear all error messages
            nameValidationLabel.Visible = false;
            rollNumberValidationLabel.Visible = false;
            departmentValidationLabel.Visible = false;
            emailValidationLabel.Visible = false;
            passwordValidationLabel.Visible = false;
            conformPasswordValidationLabel.Visible = false;
        }
    }
}
