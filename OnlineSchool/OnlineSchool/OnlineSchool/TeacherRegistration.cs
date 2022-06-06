using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineSchool
{
    public partial class TeacherRegistration : Form
    {
        public TeacherRegistration()
        {
            InitializeComponent();

        }

        private void TeacherRegistration_Load(object sender, EventArgs e)
        {
            txtLogInPassword.PasswordChar = '*';
            txtSignUpPassword.PasswordChar = '*';
        }

        private void btnTeacher_SignUp_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            /*Teacher teacher=new Teacher(txtName.Text,txtSurname.Text,
                txtSignUpEmail.Text,txtSignUpPassword.Text,Convert.ToInt32(txtMobileNumber),
                cmbGender.Text,txtSchool.Text,cmbSubject.Text,Convert.ToDecimal(txtSalary));*/
            
            SQLProcedures.insertTeacher(teacher);
            

        }
    }
}
