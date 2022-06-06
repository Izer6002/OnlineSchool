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
            int numberOfUpperCases = 0;
            if (txtName.Text.Length==0 ||
                txtSurname.Text.Length == 0 ||
                txtSignUpEmail.Text.Length == 0 ||
                txtSignUpPassword.Text.Length == 0 ||
                txtMobileNumber.Text.Length == 0 ||
                cmbGrade.Text.Length == 0 ||
                cmbGender.Text.Length == 0 ||
                txtSchool.Text.Length == 0)
            {
                MessageBox.Show("There Is Blank Space Left.Please Fill IT !");
                return;
            }

            if (txtSignUpPassword.Text.Length < 8)
            {
                MessageBox.Show("Password Is Too Short");
            }

            for(int i = 0;i< txtSignUpPassword.Text.Length; i++)
            {
                if(txtSignUpPassword.Text[i]>'A' && txtSignUpPassword.Text[i] < 'Z')
                {
                    numberOfUpperCases++;
                }
            }

            if (numberOfUpperCases == 0)
            {
                MessageBox.Show("Password Must Contain At Least One Upper Case ! ");
            }
            

            Students students = new Students(
                txtName.Text,
                txtSurname.Text,
                txtSignUpEmail.Text,
                txtSignUpPassword.Text,
                Convert.ToInt32(txtMobileNumber.Text),
                Convert.ToInt32(cmbGrade.Text),
                cmbGender.Text,
                txtSchool.Text
                );

            SQLProcedures.insertStudent(students);
            txtName.Text = " ";
            txtSurname.Text = " ";
            txtSignUpEmail.Text = " ";
            txtSignUpPassword.Text = " ";
            txtSchool.Text = " ";
            cmbGrade.Text = " ";
            txtMobileNumber.Text = " ";
            cmbGender.Text = " ";


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

        private void lblGrade_Click(object sender, EventArgs e)
        {

        }
    }
}
