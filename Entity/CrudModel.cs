using EmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace EmployeeApp.Entity
{
    public class CrudModel
    {
        static DataTable dt;
        static SqlDataAdapter da;
        public DataTable GetAllEmployees()
        {
            dt = new DataTable();
            string strConString = @"Server=10.0.103.99\SQL2008R2;Database=SQL_Training;User ID=training;Password=training;";
            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from Employee";
                cmd.Connection = con;

                 da= new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        
        public DataTable GetEmployeeById(int id)
        {
            string str = @"Server=10.0.103.99\SQL2008R2;Database=SQL_Training;User ID=training;Password=training;";

            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Sp_Sel_Employee";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@EmployeeId", id);

            dt = new DataTable();


            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        //public DataTable SearchEmployees(Employee employee)
        //{
        //    DataTable dt = new DataTable();
        //    string SQL = "Sp_Sel_Employee";
        //    string strConString = @"Server=10.0.103.99\SQL2008R2;Database=SQL_Training;User ID=training;Password=training;";
        //    using (SqlConnection con = new SqlConnection(strConString))
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand(SQL, con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        r4
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(dt);
        //    }
        //    return dt;
        //}

        ///// <summary>  
        ///// Get student detail by Student id  
        ///// </summary>  
        ///// <param name="intStudentID"></param>  
        ///// <returns></returns>  
        //public DataTable GetStudentByID(int intStudentID)
        //{
        //    DataTable dt = new DataTable();

        //    string strConString = @"Data Source=WELCOME-PC\SQLSERVER2008;Initial Catalog=MyDB;Integrated Security=True";

        //    using (SqlConnection con = new SqlConnection(strConString))
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("Select * from tblStudent where student_id=" + intStudentID, con);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(dt);
        //    }
        //    return dt;
        //}

        ///// <summary>  
        ///// Update the student details  
        ///// </summary>  
        ///// <param name="intStudentID"></param>  
        ///// <param name="strStudentName"></param>  
        ///// <param name="strGender"></param>  
        ///// <param name="intAge"></param>  
        ///// <returns></returns>  
        //public int UpdateStudent(int intStudentID, string strStudentName, string strGender, int intAge)
        //{
        //    string strConString = @"Data Source=WELCOME-PC\SQLSERVER2008;Initial Catalog=MyDB;Integrated Security=True";

        //    using (SqlConnection con = new SqlConnection(strConString))
        //    {
        //        con.Open();
        //        string query = "Update tblStudent SET student_name=@studname, student_age=@studage , student_gender=@gender where student_id=@studid";
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        cmd.Parameters.AddWithValue("@studname", strStudentName);
        //        cmd.Parameters.AddWithValue("@studage", intAge);
        //        cmd.Parameters.AddWithValue("@gender", strGender);
        //        cmd.Parameters.AddWithValue("@studid", intStudentID);
        //        return cmd.ExecuteNonQuery();
        //    }
        //}

        ///// <summary>  
        ///// Insert Student record into DB  
        ///// </summary>  
        ///// <param name="strStudentName"></param>  
        ///// <param name="strGender"></param>  
        ///// <param name="intAge"></param>  
        ///// <returns></returns>  
        //public int InsertStudent(string strStudentName, string strGender, int intAge)
        //{
        //    string strConString = @"Data Source=WELCOME-PC\SQLSERVER2008;Initial Catalog=MyDB;Integrated Security=True";

        //    using (SqlConnection con = new SqlConnection(strConString))
        //    {
        //        con.Open();
        //        string query = "Insert into tblStudent (student_name, student_age,student_gender) values(@studname, @studage , @gender)";
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        cmd.Parameters.AddWithValue("@studname", strStudentName);
        //        cmd.Parameters.AddWithValue("@studage", intAge);
        //        cmd.Parameters.AddWithValue("@gender", strGender);
        //        return cmd.ExecuteNonQuery();
        //    }
        //}

        ///// <summary>  
        ///// Delete student based on ID  
        ///// </summary>  
        ///// <param name="intStudentID"></param>  
        ///// <returns></returns>  
        //public int DeleteStudent(int intStudentID)
        //{
        //    string strConString = @"Data Source=WELCOME-PC\SQLSERVER2008;Initial Catalog=MyDB;Integrated Security=True";

        //    using (SqlConnection con = new SqlConnection(strConString))
        //    {
        //        con.Open();
        //        string query = "Delete from tblStudent where student_id=@studid";
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        cmd.Parameters.AddWithValue("@studid", intStudentID);
        //        return cmd.ExecuteNonQuery();
        //    }
        //}

    }
}