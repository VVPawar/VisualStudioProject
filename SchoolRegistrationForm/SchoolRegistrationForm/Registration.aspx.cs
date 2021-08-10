using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataBaseConn;

namespace SchoolRegistrationForm
{
    public partial class Registration : System.Web.UI.Page
    {
        public string connString = "Data Source=DESKTOP-DSQCCTI;Initial Catalog=SchoolRegistrationForm;Integrated Security=True";
        DataBaseFache conData = new DataBaseFache();
       
        String s;
        protected void Page_Load(object sender, EventArgs e)
        {
            s = Request.QueryString["Sid"];
            int i = Convert.ToInt32(s);
            if (i != 0) {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                Button1.Visible = true;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        cmd = new SqlCommand("CopyTextbox", conn);
                        cmd.Parameters.Add(new SqlParameter("@sid", i));
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine(Environment.NewLine + "Executing stored procedure..." + Environment.NewLine);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SiblingId.Visible = true;
                                String Studentid = reader[0].ToString();
                                String sibling = reader[1].ToString(); ;
                                Admission_No.Value = reader[2].ToString();
                                Sibling_class.Value = reader[3].ToString();
                                Sibling_Name.Value = reader[4].ToString();
                                F_Name.Value = reader[5].ToString();
                                L_Name.Value = reader[6].ToString();
                                M_name.Value = reader[7].ToString();
                                Selectgenderid.Value = reader[8].ToString();
                                String DOB = reader[9].ToString();
                                AcademicID.Value = reader[10].ToString();
                                Student_Type.Value = reader[11].ToString();
                                Classid.Value = reader[12].ToString();
                                MotherT.Value = reader[13].ToString();
                                EmID.Value = reader[14].ToString();
                                Religionid.Value = reader[15].ToString();
                                PS.Value = reader[16].ToString();
                                phs.Value = reader[17].ToString();
                                Ts.Value = reader[18].ToString();
                                Nationalityid.Value = reader[19].ToString();
                                String SP = reader[20].ToString();
                                P_Address.Value = reader[21].ToString();
                                P_City.Value = reader[22].ToString();
                                P_pin.Value = reader[23].ToString();
                                P_State.Value = reader[24].ToString();
                                String Temp = reader[25].ToString();
                                T_Address.Value = reader[26].ToString();
                                T_City.Value = reader[27].ToString();
                                T_pin.Value = reader[28].ToString();
                                T_State.Value = reader[29].ToString();
                                T_Country.Value = reader[30].ToString();
                                Father_Name.Value = reader[31].ToString();
                                Qualificationid.Value = reader[32].ToString();
                                MF.Value = reader[33].ToString();
                                AddressF.Value = reader[34].ToString();
                                Fid.Value = reader[35].ToString();
                                Tf.Value = reader[36].ToString();
                                Occupationid.Value = reader[37].ToString();
                                ModerniteIdF.Value = reader[38].ToString();
                                Modernite_YF.Value = reader[39].ToString();
                                MoBF.Value = reader[40].ToString();
                                String PhotoF = reader[41].ToString();
                                MN.Value = reader[42].ToString();
                                Qualificationfid.Value = reader[43].ToString();
                                MobileM.Value = reader[44].ToString();
                                OffAdd.Value = reader[45].ToString();
                                Em.Value = reader[46].ToString();
                                TellMo.Value = reader[47].ToString();
                                ccupationfid.Value = reader[48].ToString();
                                ModerniteId.Value = reader[49].ToString();
                                Modernite_Y.Value = reader[50].ToString();
                                Modernite_Text.Value = reader[51].ToString();
                                String PhotoFM = reader[52].ToString();

                            }
                        }

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



        protected void submitId_Click(object sender, EventArgs e)
        {
            AddDataClass ADC = new AddDataClass();
            ADC.SD_get = new StudentDetailClass();
            ADC.SDC_get = new SiblingDetailslClass();
            ADC.AD_get = new AddressDetailsClass();
            ADC.FD_get = new FatherDetailClass();
            ADC.MD_get = new MotherDetailClass();
            ADC.SD_get.StudentFirstName = F_Name.Value;
            ADC.SD_get.LastName = L_Name.Value;
            ADC.SD_get.MiddleName = M_name.Value;
            ADC.SD_get.Gender = Selectgenderid.Value;
            ADC.SD_get.DOB = "'2021-07-04 23:03:43.290'";
            ADC.SD_get.AcademicYear = AcademicID.Value;
            ADC.SD_get.StudentType = Student_Type.Value;
            ADC.SD_get.Classs = Classid.Value;
            ADC.SD_get.MotherTongue = MotherT.Value;
            ADC.SD_get.StudentEmailId = EmID.Value;
            ADC.SD_get.Religion = Religionid.Value;
            ADC.SD_get.PreviousSchool = PS.Value;
            ADC.SD_get.MobileNo = Convert.ToDouble(phs.Value);
            ADC.SD_get.Telephone = Convert.ToDouble(Ts.Value);
            ADC.SD_get.Nationality = Nationalityid.Value;
            ADC.SD_get.StudentPhoto = null;

            ADC.SDC_get.Sibling = true;
            if ((Admission_No.Value) == "") {
                ADC.SDC_get.AdmissionNo = 0;
            }
            else {
                ADC.SDC_get.AdmissionNo = Convert.ToDouble(Admission_No.Value);
            }

            ADC.SDC_get.SiblingName = Sibling_Name.Value;
            ADC.SDC_get.SiblingClass = Sibling_class.Value;

            ADC.AD_get.AddressP = P_Address.Value;
            ADC.AD_get.CityP = P_City.Value;
            ADC.AD_get.PinCodeP = Convert.ToInt32(P_pin.Value);
            ADC.AD_get.StateP = P_State.Value;
            ADC.AD_get.PermTemp = "Temp";
            ADC.AD_get.AddressT = T_Address.Value;
            ADC.AD_get.CityT = T_City.Value;
            ADC.AD_get.PinCodeT = Convert.ToInt32(T_pin.Value);
            ADC.AD_get.StateT = T_State.Value;
            ADC.AD_get.CountryT = T_Country.Value;

            ADC.FD_get.FatherName = Father_Name.Value;
            ADC.FD_get.Qualification = Qualificationid.Value;
            ADC.FD_get.FatherMobileno = Convert.ToDouble(MF.Value);
            ADC.FD_get.FatherOfficeAddress = AddressF.Value;
            ADC.FD_get.FatherEmailId = Fid.Value;
            ADC.FD_get.FatherTelephone = Convert.ToDouble(Tf.Value);
            ADC.FD_get.FatherOccupation = Occupationid.Value;
            ADC.FD_get.FatherModernite = ModerniteIdF.Value;
            ADC.FD_get.FatherModerniteYear = Modernite_YF.Value;
            ADC.FD_get.FatherModerniteBranch = MoBF.Value;
            ADC.FD_get.FatherPhoto = null;

            ADC.MD_get.MotherName = MN.Value;
            ADC.MD_get.MotherQualification = Qualificationfid.Value;
            ADC.MD_get.MotherMobileno = Convert.ToDouble(MobileM.Value);
            ADC.MD_get.MotherOfficeAddress = OffAdd.Value;
            ADC.MD_get.MotherEmailId = Em.Value;
            ADC.MD_get.MotherTelephone = Convert.ToDouble(TellMo.Value);
            ADC.MD_get.MotherOccupation = ccupationfid.Value;
            ADC.MD_get.MotherModernite = ModerniteId.Value;
            ADC.MD_get.MotherModerniteYear = Modernite_Y.Value;
            ADC.MD_get.MotherModerniteBranch = Modernite_Text.Value;
            ADC.MD_get.MotherPhoto = null;

            conData.InserStudent(ADC);

            F_Name.Value = "";
            L_Name.Value = "";
            M_name.Value = "";
            Selectgenderid.Value = "";
            AcademicID.Value = "";
            Student_Type.Value = "";
            Classid.Value = "";
            MotherT.Value = "";
            EmID.Value = "";
            Religionid.Value = "";
            PS.Value = "";
            phs.Value = "";
            Ts.Value = "";
            Nationalityid.Value = "";

            Admission_No.Value = "";
            Sibling_Name.Value = "";
            Sibling_class.Value = "";

            P_Address.Value = "";
            P_City.Value = "";
            P_pin.Value = "";
            P_State.Value = "";
            T_Address.Value = "";
            T_City.Value = "";
            T_State.Value = "";
            T_Country.Value = "";

            Father_Name.Value = "";
            Qualificationid.Value = "";
            MF.Value = "";
            AddressF.Value = "";
            Fid.Value = "";
            Tf.Value = "";
            Occupationid.Value = "";
            ModerniteIdF.Value = "";
            Modernite_YF.Value = "";
            MoBF.Value = "";

            MN.Value = "";
            Qualificationfid.Value = "";
            MobileM.Value = "";
            OffAdd.Value = "";
            Em.Value = "";
            TellMo.Value = "";
            ccupationfid.Value = "";
            ModerniteId.Value = "";
            Modernite_Y.Value = "";
            Modernite_Text.Value = "";

            Response.Redirect("Display.aspx");
        }
        public void getDtext() {
            AddDataClass ADC = new AddDataClass();
            ADC.SD_get = new StudentDetailClass();
            ADC.SDC_get = new SiblingDetailslClass();
            ADC.AD_get = new AddressDetailsClass();
            ADC.FD_get = new FatherDetailClass();
            ADC.MD_get = new MotherDetailClass();
            ADC.SD_get.StudentFirstName = F_Name.Value;
            ADC.SD_get.LastName = L_Name.Value;
            ADC.SD_get.MiddleName = M_name.Value;
            ADC.SD_get.Gender = Selectgenderid.Value;
            ADC.SD_get.DOB = "'2021-07-04 23:03:43.290'";
            ADC.SD_get.AcademicYear = AcademicID.Value;
            ADC.SD_get.StudentType = Student_Type.Value;
            ADC.SD_get.Classs = Classid.Value;
            ADC.SD_get.MotherTongue = MotherT.Value;
            ADC.SD_get.StudentEmailId = EmID.Value;
            ADC.SD_get.Religion = Religionid.Value;
            ADC.SD_get.PreviousSchool = PS.Value;
            ADC.SD_get.MobileNo = Convert.ToDouble(phs.Value);
            ADC.SD_get.Telephone = Convert.ToDouble(Ts.Value);
            ADC.SD_get.Nationality = Nationalityid.Value;
            ADC.SD_get.StudentPhoto = null;

            ADC.SDC_get.Sibling = true;
            if ((Admission_No.Value) == "")
            {
                ADC.SDC_get.AdmissionNo = 0;
            }
            else
            {
                ADC.SDC_get.AdmissionNo = Convert.ToDouble(Admission_No.Value);
            }

            ADC.SDC_get.SiblingName = Sibling_Name.Value;
            ADC.SDC_get.SiblingClass = Sibling_class.Value;

            ADC.AD_get.AddressP = P_Address.Value;
            ADC.AD_get.CityP = P_City.Value;
            ADC.AD_get.PinCodeP = Convert.ToInt32(P_pin.Value);
            ADC.AD_get.StateP = P_State.Value;
            ADC.AD_get.PermTemp = "Temp";
            ADC.AD_get.AddressT = T_Address.Value;
            ADC.AD_get.CityT = T_City.Value;
            ADC.AD_get.PinCodeT = Convert.ToInt32(T_pin.Value);
            ADC.AD_get.StateT = T_State.Value;
            ADC.AD_get.CountryT = T_Country.Value;

            ADC.FD_get.FatherName = Father_Name.Value;
            ADC.FD_get.Qualification = Qualificationid.Value;
            ADC.FD_get.FatherMobileno = Convert.ToDouble(MF.Value);
            ADC.FD_get.FatherOfficeAddress = AddressF.Value;
            ADC.FD_get.FatherEmailId = Fid.Value;
            ADC.FD_get.FatherTelephone = Convert.ToDouble(Tf.Value);
            ADC.FD_get.FatherOccupation = Occupationid.Value;
            ADC.FD_get.FatherModernite = ModerniteIdF.Value;
            ADC.FD_get.FatherModerniteYear = Modernite_YF.Value;
            ADC.FD_get.FatherModerniteBranch = MoBF.Value;
            ADC.FD_get.FatherPhoto = null;

            ADC.MD_get.MotherName = MN.Value;
            ADC.MD_get.MotherQualification = Qualificationfid.Value;
            ADC.MD_get.MotherMobileno = Convert.ToDouble(MobileM.Value);
            ADC.MD_get.MotherOfficeAddress = OffAdd.Value;
            ADC.MD_get.MotherEmailId = Em.Value;
            ADC.MD_get.MotherTelephone = Convert.ToDouble(TellMo.Value);
            ADC.MD_get.MotherOccupation = ccupationfid.Value;
            ADC.MD_get.MotherModernite = ModerniteId.Value;
            ADC.MD_get.MotherModerniteYear = Modernite_Y.Value;
            ADC.MD_get.MotherModerniteBranch = Modernite_Text.Value;
            ADC.MD_get.MotherPhoto = null;

            int i = Convert.ToInt32(s);
            conData.UpdateStudent(i, ADC);

            F_Name.Value = "";
            L_Name.Value = "";
            M_name.Value = "";
            Selectgenderid.Value = "";
            AcademicID.Value = "";
            Student_Type.Value = "";
            Classid.Value = "";
            MotherT.Value = "";
            EmID.Value = "";
            Religionid.Value = "";
            PS.Value = "";
            phs.Value = "";
            Ts.Value = "";
            Nationalityid.Value = "";

            Admission_No.Value = "";
            Sibling_Name.Value = "";
            Sibling_class.Value = "";

            P_Address.Value = "";
            P_City.Value = "";
            P_pin.Value = "";
            P_State.Value = "";
            T_Address.Value = "";
            T_City.Value = "";
            T_State.Value = "";
            T_Country.Value = "";

            Father_Name.Value = "";
            Qualificationid.Value = "";
            MF.Value = "";
            AddressF.Value = "";
            Fid.Value = "";
            Tf.Value = "";
            Occupationid.Value = "";
            ModerniteIdF.Value = "";
            Modernite_YF.Value = "";
            MoBF.Value = "";

            MN.Value = "";
            Qualificationfid.Value = "";
            MobileM.Value = "";
            OffAdd.Value = "";
            Em.Value = "";
            TellMo.Value = "";
            ccupationfid.Value = "";
            ModerniteId.Value = "";
            Modernite_Y.Value = "";
            Modernite_Text.Value = "";

            Response.Redirect("Display.aspx");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            getDtext();
        }
    }
}