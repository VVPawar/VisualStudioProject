using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace StudentData
{
    public class StudentReff
    {
       public string connString = "Data Source=DESKTOP-DSQCCTI;Initial Catalog=StudentRegistrationForm1;Integrated Security=True";
        public DataTable GetEmployees()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    cmd = new SqlCommand("SelectStudentDetail", conn);
                    //  cmd.Parameters.Add(new SqlParameter("@EMPLOYEENO", employeeNo));
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception x)
            {
            }
            finally
            {
                cmd.Dispose();
                //conn.Close();
            }
            return dt;
        }
        public void DelectEmployees(int StudentId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    cmd = new SqlCommand("DelectStudentId", conn);
                    cmd.Parameters.Add(new SqlParameter("@StudentId", StudentId));
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception x)
            {
            }
            finally
            {
                cmd.Dispose();
                //conn.Close();
            }
           // return 0;
        }
    }
}
