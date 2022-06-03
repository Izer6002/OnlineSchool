namespace OnlineSchool
{
    public class Students
    {
        public string name, surname, email, password, school, gender;
        public int mobilePhone, grade;

        public Students(string name, string surname, string email, string password, int mobilePhone, int grade, string gender, string school)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
            this.gender = gender;
            this.grade = grade;
            this.school = school;
            this.mobilePhone = mobilePhone;
        }
    }
}
