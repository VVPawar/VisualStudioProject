using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataBaseConnection
{
    public class Connection
    {
        public string connString = "Data Source=DESKTOP-DSQCCTI;Initial Catalog=DemoProject;Integrated Security=True";
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
        public void InserEmployees(String StudentName, String MiddleName, String LastName, String FatherName, String Email, String Mob, String MotherName, String MotherEmail,String MotherMob)
        {
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
                    SqlParameter MN = new SqlParameter();
                    MN.ParameterName = "@MiddleName";
                    MN.SqlDbType = SqlDbType.VarChar;
                    MN.Value = MiddleName;
                    SqlParameter LN = new SqlParameter();
                    LN.ParameterName = "@LastName";
                    LN.SqlDbType = SqlDbType.VarChar;
                    LN.Value = LastName;
                    SqlParameter FN = new SqlParameter();
                    FN.ParameterName = "@FatherName";
                    FN.SqlDbType = SqlDbType.VarChar;
                    FN.Value = FatherName;
                    SqlParameter FM = new SqlParameter();
                    FM.ParameterName = "@Email";
                    FM.SqlDbType = SqlDbType.VarChar;
                    FM.Value = Email;
                    SqlParameter FE = new SqlParameter();
                    FE.ParameterName = "@Mob";
                    FE.SqlDbType = SqlDbType.VarChar;
                    FE.Value = Mob;
                    SqlParameter MNM = new SqlParameter();
                    MNM.ParameterName = "@MotherName";
                    MNM.SqlDbType = SqlDbType.VarChar;
                    MNM.Value = MotherName;
                    SqlParameter ME = new SqlParameter();
                    ME.ParameterName = "@MotherEmail";
                    ME.SqlDbType = SqlDbType.VarChar;
                    ME.Value = MotherEmail;
                    SqlParameter MM = new SqlParameter();
                    MM.ParameterName = "@MotherMob";
                    MM.SqlDbType = SqlDbType.VarChar;
                    MM.Value = MotherMob;
                    //add the parameter to the SqlCommand object
                    cmd.Parameters.Add(SN);
                    cmd.Parameters.Add(MN);
                    cmd.Parameters.Add(LN);
                    cmd.Parameters.Add(FN);
                    cmd.Parameters.Add(FM);
                    cmd.Parameters.Add(FE);
                    cmd.Parameters.Add(MNM);
                    cmd.Parameters.Add(ME);
                    cmd.Parameters.Add(MM);
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
                    cmd.Parameters.Add(new SqlParameter("@studentId", StudentId));
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
