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
        public static string connstr = "Data Source=KIU-PC\\SQLEXPRESS;Initial Catalog = OnlineShop; Integrated Security = True";
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

        public static void insertStudent(Students students)
        {
            cmd = new SqlCommand("InsertStudent",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] sp = new SqlParameter[8];
            sp[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50, students.name);
            sp[1] = new SqlParameter("@surname", SqlDbType.NVarChar, 50, students.surname);
            sp[2] = new SqlParameter("@email", SqlDbType.NVarChar, 50, students.email);
            sp[3] = new SqlParameter("@password", SqlDbType.NVarChar, 50, students.password);
            sp[4] = new SqlParameter("@mobilePhone", SqlDbType.Int,students.mobilePhone);
            sp[5] = new SqlParameter("@grade", SqlDbType.Int,students.grade);
            sp[6] = new SqlParameter("@gender", SqlDbType.NVarChar, 50, students.gender);
            sp[7] = new SqlParameter("@school", SqlDbType.NVarChar, 50, students.school);
            cmd.Parameters.AddRange(sp);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

    }


}
