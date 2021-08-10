using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataBaseConn
{
    public class DataBaseFache
    {
        public string connString = "Data Source=DESKTOP-DSQCCTI;Initial Catalog=SchoolRegistrationForm;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public void InserStudent(AddDataClass Student)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    cmd = new SqlCommand("InsetStudenDetail", conn);
                    cmd.Parameters.Add(new SqlParameter("@StudentFirstName", Student.SD_get.StudentFirstName));
                    cmd.Parameters.Add(new SqlParameter("@LastName", Student.SD_get.LastName));
                    cmd.Parameters.Add(new SqlParameter("@MiddleName", Student.SD_get.MiddleName));
                    cmd.Parameters.Add(new SqlParameter("@DOB", Student.SD_get.DOB));
                    cmd.Parameters.Add(new SqlParameter("@Gender", Student.SD_get.Gender));
                    cmd.Parameters.Add(new SqlParameter("@AcademicYear", Student.SD_get.AcademicYear));
                    cmd.Parameters.Add(new SqlParameter("@StudentType", Student.SD_get.StudentType));
                    cmd.Parameters.Add(new SqlParameter("@Class", Student.SD_get.Classs));
                    cmd.Parameters.Add(new SqlParameter("@MotherTongue", Student.SD_get.MotherTongue));
                    cmd.Parameters.Add(new SqlParameter("@StudentEmailId", Student.SD_get.StudentEmailId));
                    cmd.Parameters.Add(new SqlParameter("@Religion", Student.SD_get.Religion));
                    cmd.Parameters.Add(new SqlParameter("@PreviousSchool", Student.SD_get.PreviousSchool));
                    cmd.Parameters.Add(new SqlParameter("@MobileNo", Student.SD_get.MobileNo));
                    cmd.Parameters.Add(new SqlParameter("@Telephone", Student.SD_get.Telephone));
                    cmd.Parameters.Add(new SqlParameter("@Nationality", Student.SD_get.Nationality));
                    cmd.Parameters.Add(new SqlParameter("@StudentPhoto", Student.SD_get.StudentPhoto));

                    cmd.Parameters.Add(new SqlParameter("@Sibling", Student.SDC_get.Sibling));
                    cmd.Parameters.Add(new SqlParameter("@AdmissionNo", Student.SDC_get.AdmissionNo));
                    cmd.Parameters.Add(new SqlParameter("@SiblingName", Student.SDC_get.SiblingName));
                    cmd.Parameters.Add(new SqlParameter("@SiblingClass", Student.SDC_get.SiblingClass));

                    cmd.Parameters.Add(new SqlParameter("@AddressP", Student.AD_get.AddressP));
                    cmd.Parameters.Add(new SqlParameter("@CityP", Student.AD_get.CityP));
                    cmd.Parameters.Add(new SqlParameter("@PinCodeP", Student.AD_get.PinCodeP));
                    cmd.Parameters.Add(new SqlParameter("@StateP", Student.AD_get.StateP));
                    cmd.Parameters.Add(new SqlParameter("@PermTemp", Student.AD_get.PermTemp));
                    cmd.Parameters.Add(new SqlParameter("@AddressT", Student.AD_get.AddressT));
                    cmd.Parameters.Add(new SqlParameter("@CityT", Student.AD_get.CityT));
                    cmd.Parameters.Add(new SqlParameter("@PinCodeT", Student.AD_get.PinCodeT));
                    cmd.Parameters.Add(new SqlParameter("@StateT", Student.AD_get.StateT));
                    cmd.Parameters.Add(new SqlParameter("@CountryT", Student.AD_get.CountryT));

                    cmd.Parameters.Add(new SqlParameter("@FatherName",Student.FD_get.FatherName));
                    cmd.Parameters.Add(new SqlParameter("@Qualification", Student.FD_get.Qualification));
                    cmd.Parameters.Add(new SqlParameter("@FatherMobileno", Student.FD_get.FatherMobileno));
                    cmd.Parameters.Add(new SqlParameter("@FatherOfficeAddress", Student.FD_get.FatherOfficeAddress));
                    cmd.Parameters.Add(new SqlParameter("@FatherEmailId", Student.FD_get.FatherEmailId));
                    cmd.Parameters.Add(new SqlParameter("@FatherTelephone", Student.FD_get.FatherTelephone));
                    cmd.Parameters.Add(new SqlParameter("@FatherOccupation", Student.FD_get.FatherOccupation));
                    cmd.Parameters.Add(new SqlParameter("@FatherModernite", Student.FD_get.FatherModernite));
                    cmd.Parameters.Add(new SqlParameter("@FatherModerniteYear", Student.FD_get.FatherModerniteYear));
                    cmd.Parameters.Add(new SqlParameter("@FatherModerniteBranch", Student.FD_get.FatherModerniteBranch));
                    cmd.Parameters.Add(new SqlParameter("@FatherPhoto", Student.FD_get.FatherPhoto));

                    cmd.Parameters.Add(new SqlParameter("@MotherName",Student.MD_get.MotherName));
                    cmd.Parameters.Add(new SqlParameter("@MotherQualification", Student.MD_get.MotherQualification));
                    cmd.Parameters.Add(new SqlParameter("@MotherMobileno", Student.MD_get.MotherMobileno));
                    cmd.Parameters.Add(new SqlParameter("@MotherOfficeAddress", Student.MD_get.MotherOfficeAddress));
                    cmd.Parameters.Add(new SqlParameter("@MotherEmailId", Student.MD_get.MotherEmailId));
                    cmd.Parameters.Add(new SqlParameter("@MotherTelephone", Student.MD_get.MotherTelephone));
                    cmd.Parameters.Add(new SqlParameter("@MotherOccupation", Student.MD_get.MotherOccupation));
                    cmd.Parameters.Add(new SqlParameter("@MotherModernite", Student.MD_get.MotherModernite));
                    cmd.Parameters.Add(new SqlParameter("@MotherModerniteYear", Student.MD_get.MotherModerniteYear));
                    cmd.Parameters.Add(new SqlParameter("@MotherModerniteBranch", Student.MD_get.MotherModerniteBranch));
                    cmd.Parameters.Add(new SqlParameter("@MotherPhoto", Student.MD_get.MotherPhoto));
 
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
        public void UpdateStudent(int s, AddDataClass Student)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    cmd = new SqlCommand("UpdateStudentDetail", conn);
                    cmd.Parameters.Add(new SqlParameter("@sid", s));
                    cmd.Parameters.Add(new SqlParameter("@StudentFirstName", Student.SD_get.StudentFirstName));
                    cmd.Parameters.Add(new SqlParameter("@LastName", Student.SD_get.LastName));
                    cmd.Parameters.Add(new SqlParameter("@MiddleName", Student.SD_get.MiddleName));
                    cmd.Parameters.Add(new SqlParameter("@Gender", Student.SD_get.Gender));
                    cmd.Parameters.Add(new SqlParameter("@DOB", Student.SD_get.DOB));
                    cmd.Parameters.Add(new SqlParameter("@AcademicYear", Student.SD_get.AcademicYear));
                    cmd.Parameters.Add(new SqlParameter("@StudentType", Student.SD_get.StudentType));
                    cmd.Parameters.Add(new SqlParameter("@Class", Student.SD_get.Classs));
                    cmd.Parameters.Add(new SqlParameter("@MotherTongue", Student.SD_get.MotherTongue));
                    cmd.Parameters.Add(new SqlParameter("@StudentEmailId", Student.SD_get.StudentEmailId));
                    cmd.Parameters.Add(new SqlParameter("@Religion", Student.SD_get.Religion));
                    cmd.Parameters.Add(new SqlParameter("@PreviousSchool", Student.SD_get.PreviousSchool));
                    cmd.Parameters.Add(new SqlParameter("@MobileNo", Student.SD_get.MobileNo));
                    cmd.Parameters.Add(new SqlParameter("@Telephone", Student.SD_get.Telephone));
                    cmd.Parameters.Add(new SqlParameter("@Nationality", Student.SD_get.Nationality));
                   // cmd.Parameters.Add(new SqlParameter("@StudentPhoto", null));

                    cmd.Parameters.Add(new SqlParameter("@Sibling", Student.SDC_get.Sibling));
                    cmd.Parameters.Add(new SqlParameter("@AdmissionNo", Student.SDC_get.AdmissionNo));
                    cmd.Parameters.Add(new SqlParameter("@SiblingName", Student.SDC_get.SiblingName));
                    cmd.Parameters.Add(new SqlParameter("@SiblingClass", Student.SDC_get.SiblingClass));

                    cmd.Parameters.Add(new SqlParameter("@AddressP", Student.AD_get.AddressP));
                    cmd.Parameters.Add(new SqlParameter("@CityP", Student.AD_get.CityP));
                    cmd.Parameters.Add(new SqlParameter("@PinCodeP", Student.AD_get.PinCodeP));
                    cmd.Parameters.Add(new SqlParameter("@StateP", Student.AD_get.StateP));
                    cmd.Parameters.Add(new SqlParameter("@PermTemp", Student.AD_get.PermTemp));
                    cmd.Parameters.Add(new SqlParameter("@AddressT", Student.AD_get.AddressT));
                    cmd.Parameters.Add(new SqlParameter("@CityT", Student.AD_get.CityT));
                    cmd.Parameters.Add(new SqlParameter("@PinCodeT", Student.AD_get.PinCodeT));
                    cmd.Parameters.Add(new SqlParameter("@StateT", Student.AD_get.StateT));
                    cmd.Parameters.Add(new SqlParameter("@CountryT", Student.AD_get.CountryT));

                    cmd.Parameters.Add(new SqlParameter("@FatherName", Student.FD_get.FatherName));
                    cmd.Parameters.Add(new SqlParameter("@Qualification", Student.FD_get.Qualification));
                    cmd.Parameters.Add(new SqlParameter("@FatherMobileno", Student.FD_get.FatherMobileno));
                    cmd.Parameters.Add(new SqlParameter("@FatherOfficeAddress", Student.FD_get.FatherOfficeAddress));
                    cmd.Parameters.Add(new SqlParameter("@FatherEmailId", Student.FD_get.FatherEmailId));
                    cmd.Parameters.Add(new SqlParameter("@FatherTelephone", Student.FD_get.FatherTelephone));
                    cmd.Parameters.Add(new SqlParameter("@FatherOccupation", Student.FD_get.FatherOccupation));
                    cmd.Parameters.Add(new SqlParameter("@FatherModernite", Student.FD_get.FatherModernite));
                    cmd.Parameters.Add(new SqlParameter("@FatherModerniteYear", Student.FD_get.FatherModerniteYear));
                    cmd.Parameters.Add(new SqlParameter("@FatherModerniteBranch", Student.FD_get.FatherModerniteBranch));
                    //cmd.Parameters.Add(new SqlParameter("@FatherPhoto", null));

                    cmd.Parameters.Add(new SqlParameter("@MotherName", Student.MD_get.MotherName));
                    cmd.Parameters.Add(new SqlParameter("@MotherQualification", Student.MD_get.MotherQualification));
                    cmd.Parameters.Add(new SqlParameter("@MotherMobileno", Student.MD_get.MotherMobileno));
                    cmd.Parameters.Add(new SqlParameter("@MotherOfficeAddress", Student.MD_get.MotherOfficeAddress));
                    cmd.Parameters.Add(new SqlParameter("@MotherEmailId", Student.MD_get.MotherEmailId));
                    cmd.Parameters.Add(new SqlParameter("@MotherTelephone", Student.MD_get.MotherTelephone));
                    cmd.Parameters.Add(new SqlParameter("@MotherOccupation", Student.MD_get.MotherOccupation));
                    cmd.Parameters.Add(new SqlParameter("@MotherModernite", Student.MD_get.MotherModernite));
                    cmd.Parameters.Add(new SqlParameter("@MotherModerniteYear", Student.MD_get.MotherModerniteYear));
                    cmd.Parameters.Add(new SqlParameter("@MotherModerniteBranch", Student.MD_get.MotherModerniteBranch));
                    //cmd.Parameters.Add(new SqlParameter("@MotherPhoto", null));

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
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    cmd = new SqlCommand("DeleteStudentDetail", conn);
                    cmd.Parameters.Add(new SqlParameter("@SID", StudentId));
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    Console.WriteLine(Environment.NewLine + "Executing stored procedure..." + Environment.NewLine);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(Environment.NewLine + "The stored procedure has been successfully executed." + Environment.NewLine);
                    conn.Close();

                }
            }
    
            finally
            {
                cmd.Dispose();
              
            }
          
        }
    }
}
