using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool
{
    internal class SQLProcedures
    {
        public static string connstr = "Data Source=WINDOWS-FH4DB52\\SQLEXPRESS;Initial Catalog=OnlineSchool;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connstr);
        public static SqlCommand cmd;
        public static SqlDataAdapter dataAdapter;
        public static DataTable Refresh()
        {
            cmd = new SqlCommand("refresh", conn);
            dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public static void insertStudent(Students student)
        {
            cmd = new SqlCommand("InsertStudent", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            sqlParameters[0].Value = student.name;
            sqlParameters[1] = new SqlParameter("@surname", SqlDbType.NVarChar, 50);
            sqlParameters[1].Value = student.surname;
            sqlParameters[2] = new SqlParameter("@email", SqlDbType.NVarChar, 50);
            sqlParameters[2].Value = student.email;
            sqlParameters[3] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
            sqlParameters[3].Value = student.password;
            sqlParameters[4] = new SqlParameter("@mobileNumber", SqlDbType.Int);
            sqlParameters[4].Value = student.mobilePhone;
            sqlParameters[5] = new SqlParameter("@grade", SqlDbType.Int);
            sqlParameters[5].Value = student.grade;
            sqlParameters[6] = new SqlParameter("@gender", SqlDbType.NVarChar, 50);
            sqlParameters[6].Value = student.gender;
            sqlParameters[7] = new SqlParameter("@school", SqlDbType.NVarChar, 50);
            sqlParameters[7].Value = student.school;
            cmd.Parameters.AddRange(sqlParameters);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static void insertTeacher(Teacher teacher)
        {
            cmd = new SqlCommand("InsertTeacher", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] sqlParameters = new SqlParameter[9];
            sqlParameters[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            sqlParameters[0].Value = teacher.name;
            sqlParameters[1] = new SqlParameter("@surname", SqlDbType.NVarChar, 50);
            sqlParameters[1].Value = teacher.surname;
            sqlParameters[2] = new SqlParameter("@email", SqlDbType.NVarChar, 50);
            sqlParameters[2].Value = teacher.email;
            sqlParameters[3] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
            sqlParameters[3].Value = teacher.password;
            sqlParameters[4] = new SqlParameter("@mobileNumber", SqlDbType.Int);
            sqlParameters[4].Value = teacher.mobilePhone;
            sqlParameters[5] = new SqlParameter("@gender", SqlDbType.NVarChar, 50);
            sqlParameters[5].Value = teacher.gender;
            sqlParameters[6] = new SqlParameter("@school", SqlDbType.NVarChar, 50);
            sqlParameters[6].Value = teacher.school;
            sqlParameters[7] = new SqlParameter("@subject", SqlDbType.Int);
            sqlParameters[7].Value = teacher.subject;
            sqlParameters[8]=new SqlParameter()
            cmd.Parameters.AddRange(sqlParameters);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }



    }


}
