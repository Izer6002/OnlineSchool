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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            TeacherRegistration teacherRegistration = new TeacherRegistration();
            teacherRegistration.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
