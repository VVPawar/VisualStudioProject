using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetStudent
{
    class DataBaseStudenDetail
    {
        string connString = "Data Source=DESKTOP-DSQCCTI;Initial Catalog=StudentRegistrationForm1;Integrated Security=True";
        public DataTable GetEmployees()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    cmd = new SqlCommand("StudentRegistrationForm1", conn);
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
    }
}
