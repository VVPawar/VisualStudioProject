using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Registration_FormMVC.Models
{
    public class connection
    {
        public string connString = "Data Source=DESKTOP-DSQCCTI;Initial Catalog=SchoolRegistrationForm;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public void InserStudent(Student model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    cmd = new SqlCommand("InsetStudenDetail", conn);
                    cmd.Parameters.Add(new SqlParameter("@StudentFirstName", model.StudentName));
                    cmd.Parameters.Add(new SqlParameter("@LastName", model.L_Name));
                    cmd.Parameters.Add(new SqlParameter("@MiddleName", model.MiddleName));
                    cmd.Parameters.Add(new SqlParameter("@DOB", model.DOB));
                    cmd.Parameters.Add(new SqlParameter("@Gender", model.StudentGender));
                    cmd.Parameters.Add(new SqlParameter("@AcademicYear", model.AcademicYear));
                    cmd.Parameters.Add(new SqlParameter("@StudentType", model.StudentType));
                    cmd.Parameters.Add(new SqlParameter("@Class", model.ClassName));
                    cmd.Parameters.Add(new SqlParameter("@MotherTongue", model.MotherT));
                    cmd.Parameters.Add(new SqlParameter("@StudentEmailId", model.Email));
                    cmd.Parameters.Add(new SqlParameter("@Religion", model.Religion));
                    cmd.Parameters.Add(new SqlParameter("@PreviousSchool", model.PreviousSchool));
                    cmd.Parameters.Add(new SqlParameter("@MobileNo", 1234567890));
                    cmd.Parameters.Add(new SqlParameter("@Telephone", 1234567890));
                    cmd.Parameters.Add(new SqlParameter("@Nationality", model.Nationality));
                    cmd.Parameters.Add(new SqlParameter("@StudentPhoto", "Null"));

                    cmd.Parameters.Add(new SqlParameter("@Sibling", true));
                    cmd.Parameters.Add(new SqlParameter("@AdmissionNo", model.Admission_No));
                    cmd.Parameters.Add(new SqlParameter("@SiblingName", model.Sibling_Name));
                    cmd.Parameters.Add(new SqlParameter("@SiblingClass", model.Sibling_Class));

                    cmd.Parameters.Add(new SqlParameter("@AddressP", model.address));
                    cmd.Parameters.Add(new SqlParameter("@CityP", model.P_City));
                    cmd.Parameters.Add(new SqlParameter("@PinCodeP",123123));
                    cmd.Parameters.Add(new SqlParameter("@StateP", model.State));
                    cmd.Parameters.Add(new SqlParameter("@PermTemp", "Temp"));
                    cmd.Parameters.Add(new SqlParameter("@AddressT", model.addressT));
                    cmd.Parameters.Add(new SqlParameter("@CityT", model.P_CityT));
                    cmd.Parameters.Add(new SqlParameter("@PinCodeT", 123123));
                    cmd.Parameters.Add(new SqlParameter("@StateT", model.StateT));
                    cmd.Parameters.Add(new SqlParameter("@CountryT", model.Contry));

                    cmd.Parameters.Add(new SqlParameter("@FatherName", model.Fname));
                    cmd.Parameters.Add(new SqlParameter("@Qualification", model.QualificationF));
                    cmd.Parameters.Add(new SqlParameter("@FatherMobileno", 1234567890));
                    cmd.Parameters.Add(new SqlParameter("@FatherOfficeAddress", model.OfficeF));
                    cmd.Parameters.Add(new SqlParameter("@FatherEmailId", model.EmailF));
                    cmd.Parameters.Add(new SqlParameter("@FatherTelephone", 1234567890));
                    cmd.Parameters.Add(new SqlParameter("@FatherOccupation", model.OccupationM));
                    cmd.Parameters.Add(new SqlParameter("@FatherModernite", model.ModerniteFYN));
                    cmd.Parameters.Add(new SqlParameter("@FatherModerniteYear", model.ModerniteMF));
                    cmd.Parameters.Add(new SqlParameter("@FatherModerniteBranch", model.ModerniteF));
                    cmd.Parameters.Add(new SqlParameter("@FatherPhoto", "Null"));

                    cmd.Parameters.Add(new SqlParameter("@MotherName", "ABC"));
                    cmd.Parameters.Add(new SqlParameter("@MotherQualification", model.QualificationF));
                    cmd.Parameters.Add(new SqlParameter("@MotherMobileno", 1234567890));
                    cmd.Parameters.Add(new SqlParameter("@MotherOfficeAddress", model.OfficeF));
                    cmd.Parameters.Add(new SqlParameter("@MotherEmailId", model.EmailM));
                    cmd.Parameters.Add(new SqlParameter("@MotherTelephone", 1234567890));
                    cmd.Parameters.Add(new SqlParameter("@MotherOccupation", model.OccupationM));
                    cmd.Parameters.Add(new SqlParameter("@MotherModernite", model.ModerniteMYN));
                    cmd.Parameters.Add(new SqlParameter("@MotherModerniteYear", model.ModerniteM));
                    cmd.Parameters.Add(new SqlParameter("@MotherModerniteBranch", model.ModerniteMB));
                    cmd.Parameters.Add(new SqlParameter("@MotherPhoto", "Null"));

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