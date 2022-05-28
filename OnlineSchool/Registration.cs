using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace OnlineSchool
{
    public partial class Registration : Form
    {

        List<Students> students = new List<Students>();
        public Registration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLogInPassword.PasswordChar = '*';
            txtSignUpPassword.PasswordChar = '*';
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LoadStudents();
            foreach (var student in students)
            {
                if (txtLogInEmail.Text == student.email)
                {
                    Main main = new Main(student);
                    main.Show();
                    this.Hide();
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Students students = new Students(
                txtName.Text,
                txtSurname.Text,
                txtSignUpEmail.Text,
                txtSignUpPassword.Text,
                Convert.ToInt32(txtMobileNumber.Text),
                Convert.ToInt32(txtGrade.Text),
                txtGender.Text,
                txtSchool.Text
                );
        }

        private void chkSignUpShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtSignUpPassword.PasswordChar = chkSignUpShowPassword.Checked ? '\0' : '*';
        }

        private void chkLogInShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtLogInPassword.PasswordChar = chkLogInShowPassword.Checked ? '\0' : '*';
        }

        private void LoadStudents()
        {
            DataTable tables = SQLProcedures.Refresh();
            for (int i = 0; i < tables.Rows.Count; i++)
            {
                students.Add(new Students(
                    (string)tables.Rows[i]["Name"],
                    (string)tables.Rows[i]["Surname"],
                    (string)tables.Rows[i]["Email"],
                    (string)tables.Rows[i]["Password"],
                    (int)tables.Rows[i]["MobileNumber"],
                    (int)tables.Rows[i]["Grade"],
                    (string)tables.Rows[i]["Gender"],
                    (string)tables.Rows[i]["School"])
                    );
            }
        }

        
    }
}
