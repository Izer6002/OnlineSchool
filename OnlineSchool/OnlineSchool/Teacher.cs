using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool
{
    internal class Teacher
    {
        public string name, surname, email, password, gender, school, subject;
        public int mobilePhone, salary;

        public Teacher(string name,string surname,string email,string password,int mobbilePhone,string gender,string school,string subject,int salary)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
            this.mobilePhone = mobbilePhone;
            this.gender = gender;
            this.school = school;
            this.subject = subject;
            this.salary = salary;
        }

    }
}
