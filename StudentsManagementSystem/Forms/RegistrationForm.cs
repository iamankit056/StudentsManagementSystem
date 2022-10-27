using MySql.Data.MySqlClient;
using StudentsManagementSystem.Scripts;
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
    public partial class RegistrationForm : Form
    {
        private DataGridView studentsDataGridView;

        public RegistrationForm(DataGridView studentsDataGridView)
        {
            InitializeComponent();
            this.studentsDataGridView = studentsDataGridView;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.name = NameTxt.Text;
            student.email = EmailTxt.Text;
            student.password = PasswordTxt.Text;
            student.department = DepartmentCBox.SelectedItem.ToString();
            student.rollNumber = Convert.ToInt32(RollNumberTxt.Text);


        }
    }
}
