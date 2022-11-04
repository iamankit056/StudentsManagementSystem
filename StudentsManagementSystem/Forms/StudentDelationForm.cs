using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
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
    public partial class StudentDelationForm : Form
    {
        private MySqlConnection mySqlConnection;

        public StudentDelationForm(MySqlConnection mySqlConnection)
        {
            InitializeComponent();
            this.mySqlConnection = mySqlConnection;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection.Open();
                string query = "delete from Students where RollNumber="+rollNumberTxt.Text;
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                int count = mySqlCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Record deleated sucessesfully");
                    errorMessageLabel.Visible = false;
                    rollNumberTxt.Text = "";
                }
                else
                {
                    errorMessageLabel.Visible = true;
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
            this.Close();
        }
    }
}
