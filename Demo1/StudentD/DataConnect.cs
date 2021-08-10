using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace StudentD
{
    public class DataConnect
    {
        public string connString = "Data Source=DESKTOP-DSQCCTI;Initial Catalog=DemoProject;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public void InserStudent(LinkStudent Student)
        {           
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    cmd = new SqlCommand("InsertData", conn);
                    cmd.Parameters.Add(new SqlParameter("@StudentName",Student.SD_get.StudentName));
                    cmd.Parameters.Add(new SqlParameter("@MiddleName", Student.SD_get.MiddleName));
                    cmd.Parameters.Add(new SqlParameter("@LastName", Student.SD_get.LastName));
                    cmd.Parameters.Add(new SqlParameter("@MotherName", Student.MD_get.MotherName));
                    cmd.Parameters.Add(new SqlParameter("@MotherEmail", Student.MD_get.MotherEmail));
                    cmd.Parameters.Add(new SqlParameter("@MotherMob", Student.MD_get.MotherMob));
                    cmd.Parameters.Add(new SqlParameter("@FatherName", Student.FD_get.FatherName));
                    cmd.Parameters.Add(new SqlParameter("@Email", Student.FD_get.Email));
                    cmd.Parameters.Add(new SqlParameter("@Mob", Student.FD_get.Mob));

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
        public void UpdateStudent(int SID,LinkStudent Student)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    cmd = new SqlCommand("UpdateSp", conn);
                    cmd.Parameters.Add(new SqlParameter("@SID", SID));
                    cmd.Parameters.Add(new SqlParameter("@StudentName", Student.SD_get.StudentName));
                    cmd.Parameters.Add(new SqlParameter("@MiddleName", Student.SD_get.MiddleName));
                    cmd.Parameters.Add(new SqlParameter("@LastName", Student.SD_get.LastName));
                    cmd.Parameters.Add(new SqlParameter("@MotherName", Student.MD_get.MotherName));
                    cmd.Parameters.Add(new SqlParameter("@MotherEmail", Student.MD_get.MotherEmail));
                    cmd.Parameters.Add(new SqlParameter("@MotherMob", Student.MD_get.MotherMob));
                    cmd.Parameters.Add(new SqlParameter("@FatherName", Student.FD_get.FatherName));
                    cmd.Parameters.Add(new SqlParameter("@Email", Student.FD_get.Email));
                    cmd.Parameters.Add(new SqlParameter("@Mob", Student.FD_get.Mob));

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
    }
}
