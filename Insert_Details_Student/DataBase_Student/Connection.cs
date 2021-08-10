using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataBase_Student
{
    public class Connection
    {
        public string connString = "Data Source=DESKTOP-DSQCCTI;Initial Catalog=InsertDetails;Integrated Security=True";
        public DataTable GetEmployees()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    cmd = new SqlCommand("Display", conn);
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
        public void InserEmployees(String StudentName,String FatherName,int Mobile,String EmailId) {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    cmd = new SqlCommand("InsertData", conn);
                    SqlParameter SN = new SqlParameter();
                    SN.ParameterName = "@StudentName";
                    SN.SqlDbType = SqlDbType.VarChar;
                    SN.Value = StudentName;
                    SqlParameter FN = new SqlParameter();
                    FN.ParameterName = "@FatherName";
                    FN.SqlDbType = SqlDbType.VarChar;
                    FN.Value = FatherName;
                    SqlParameter MN = new SqlParameter();
                    MN.ParameterName = "@Mobile";
                    MN.SqlDbType = SqlDbType.BigInt;
                    MN.Value = Mobile;
                    SqlParameter EM = new SqlParameter();
                    EM.ParameterName = "@EmailId";
                    EM.SqlDbType = SqlDbType.VarChar;
                    EM.Value = EmailId;
                    //add the parameter to the SqlCommand object
                    cmd.Parameters.Add(SN);
                    cmd.Parameters.Add(FN);
                    cmd.Parameters.Add(MN);
                    cmd.Parameters.Add(EM);
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    Console.WriteLine(Environment.NewLine + "Executing stored procedure..." + Environment.NewLine);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(Environment.NewLine + "The stored procedure has been successfully executed." + Environment.NewLine);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                Console.WriteLine("Exception: " + ex.Message);
            }

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
                    cmd = new SqlCommand("DeleteData", conn);
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
