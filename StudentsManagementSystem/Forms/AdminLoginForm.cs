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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanelForm adminPanelForm = new AdminPanelForm();
            adminPanelForm.ShowDialog();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
