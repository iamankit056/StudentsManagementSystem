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
        public StudentRegistrationForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool isErrorOccure = Validation();
            if (!isErrorOccure)
            {
                MessageBox.Show("Registration sucessesfull...");
            }
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

        private void resetBtn_Click(object sender, EventArgs e)
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
