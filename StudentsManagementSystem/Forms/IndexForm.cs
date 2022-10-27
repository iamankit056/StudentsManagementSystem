using StudentsManagementSystem.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagementSystem.Forms
{
    public partial class IndexForm : Form
    {
        private StudentsCRUD studentsCRUD;

        public IndexForm()
        {
            InitializeComponent();
            studentsCRUD = new StudentsCRUD();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            StudentsDGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentsDGrid.DataSource = studentsCRUD.Read();
        }

        private void NewRegistrationBtn_Click(object sender, EventArgs e)
        {
            new RegistrationForm(StudentsDGrid).ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
