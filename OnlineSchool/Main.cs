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
    public partial class Main : Form
    {
        private Students student;
        public Main(Students student)
        {
            this.student = student;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblName.Text = student.name + " " + student.surname;
        }

       
    }
}
