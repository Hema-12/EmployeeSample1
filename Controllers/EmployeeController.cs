using EmployeeApp.Entity;
using EmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        CrudModel model = new CrudModel();

        public ActionResult Index()
        {
            DataTable dt = model.GetAllEmployees();
            return View(dt);
        }


        public ActionResult SearchEmployees(int EmployeeId)
        {
            DataTable dt = model.GetEmployeeById(EmployeeId);
            return View(dt);
        }

        //public ActionResult Get(int id)
        //{
        //    SqlDataReader reader = null;
        //    SqlConnection myConnection = new SqlConnection();
        //    myConnection.ConnectionString = @"Server=10.0.103.99\SQL2008R2;Database=SQL_Training;User ID=training;Password=training;";

        //    SqlCommand sqlCmd = new SqlCommand();
        //    sqlCmd.CommandType = CommandType.Text;
        //    sqlCmd.CommandText = "Select * from Employee where EmployeeId=" + id + "";
        //    sqlCmd.Connection = myConnection;
        //    myConnection.Open();
        //    reader = sqlCmd.ExecuteReader();
        //    Employee emp = null;
        //    while (reader.Read())
        //    {
        //        emp = new Employee();
        //        emp.EmployeeId = Convert.ToInt32(reader.GetValue(0));
        //        emp.FirstName = reader.GetValue(1).ToString();
        //        emp.LastName = reader.GetValue(2).ToString();
        //        emp.Gender = reader.GetValue(3).ToString();
        //        emp.PhoneNumber = reader.GetValue(4).ToString();
        //        emp.EmailID = reader.GetValue(5).ToString();
        //        emp.PostalCode = reader.GetValue(6).ToString();
        //        emp.Retired = Convert.ToBoolean(reader.GetValue(7));
        //    }
        //    myConnection.Close();
        //    return View(emp);
        //}
        //public ActionResult GetAll()
        //{
        //    SqlDataReader reader = null;
        //    SqlConnection myConnection = new SqlConnection();
        //    myConnection.ConnectionString = @"Server=10.0.103.99\SQL2008R2;Database=SQL_Training;User ID=training;Password=training;";

        //    SqlCommand sqlCmd = new SqlCommand();
        //    sqlCmd.CommandType = CommandType.Text;
        //    sqlCmd.CommandText = "Select * from Employee";
        //    sqlCmd.Connection = myConnection;
        //    myConnection.Open();
        //    reader = sqlCmd.ExecuteReader();
        //    Employee emp = null;
        //    while (reader.Read())
        //    {
        //        emp = new Employee();
        //        emp.EmployeeId = Convert.ToInt32(reader.GetValue(0));
        //        emp.FirstName = reader.GetValue(1).ToString();
        //        emp.LastName = reader.GetValue(2).ToString();
        //        emp.Gender = reader.GetValue(3).ToString();
        //        emp.PhoneNumber = reader.GetValue(4).ToString();
        //        emp.EmailID = reader.GetValue(5).ToString();
        //        emp.PostalCode = reader.GetValue(6).ToString();
        //        emp.Retired = Convert.ToBoolean(reader.GetValue(7));
        //    }
        //    myConnection.Close();
        //    return View(emp);
        //}
    }
}