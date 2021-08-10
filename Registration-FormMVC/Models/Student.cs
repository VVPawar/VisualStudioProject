using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registration_FormMVC.Models
{
    public class Student
    {
        public Student()
        {
            StudentType = new List<SelectListItem>();
            Religion = new List<SelectListItem>();
            Nationality = new List<SelectListItem>();

            ClassName = new List<SelectListItem>();
            AcademicYear = new List<SelectListItem>();
        }
        public String PhotoF { get; set; }
        public String MobileF { get; set; }
        public String EmailF { get; set; }
        public String ModerniteF { get; set; }
        public String OfficeTelF { get; set; }
        public String OfficeF { get; set; }
        public String Fname { get; set; }
        public String PhotoM { get; set; }
        public String MobileM { get; set; }
        public String EmailM { get; set; }
        public String ModerniteM { get; set; }
        public String ModerniteMB { get; set; }
        public String ModerniteMF { get; set; }
        public String Contry { get; set; }
        public String P_CityT { get; set; }
        public String P_pinT { get; set; }
        public String StateT { get; set; }
        public String addressT { get; set; }
        public String P_City { get; set; }
        public String P_pin { get; set; }
        public String State { get; set; }
        public String address { get; set; }
        public String Admission_No { get; set; }
        public String Sibling_Class { get; set; }
        public String Sibling_Name { get; set; }
        [Required(ErrorMessage = "Student Name is Required")]
        public String StudentName { get; set; }
        [Required(ErrorMessage = "Student Last Name is Required")]
        public String L_Name { get; set; }
        [Required(ErrorMessage = "Date of Birth is Required")]
        public String DOB { get; set; }

        public String MotherT { get; set; }

        [Required(ErrorMessage = "Student Phone Number is Required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public String Mobile { get; set; }
        public String MiddleName { get; set; }

        public String Phone { get; set; }
        public String PreviousSchool { get; set; }
        [Required(ErrorMessage = "Email id is Required")]
        public String Email { get; set; }
        public String photo { get; set; }

        public int Age { get; set; }
        
        [DisplayName("StudentType")]
        public List<SelectListItem> StudentType
        {
            get;
            set;
        }

        [DisplayName("Religion")]
        public List<SelectListItem> Religion
        {
            get;
            set;
        }

        
        [DisplayName("Nationality")]
        public List<SelectListItem> Nationality
        {
            get;
            set;
        }

      
        [DisplayName("Gender")]
        public Gender StudentGender { get; set; }
        public QualificationF QualificationF { get; set; }

       
        [DisplayName("ModerniteFYN")]
        public ModerniteFYN ModerniteFYN { get; set; }

       
        [DisplayName("ModerniteMYN")]
        public ModerniteMYN ModerniteMYN { get; set; }

        
        [DisplayName("OccupationM")]
        public OccupationM OccupationM { get; set; }

        [Required(ErrorMessage = "Class  Required")]
        [DisplayName("ClassName")]
        public List<SelectListItem> ClassName
        {
            get;
            set;
        }

        
        [DisplayName("AcademicYear")]
        public List<SelectListItem> AcademicYear
        {
            get;
            set;
        }
    }
    public enum OccupationM
    {
        Business,
        SERVICE,
        Others,
        HOUSEWIFE,
        LECTURER,
        TEACHER,
        DOCTOR
    }
    public enum ModerniteFYN { 
        Yes,
        No
    }
    public enum ModerniteMYN
    {
        Yes,
        No
    }
    public enum Gender
    {
        Male,
        Female
    }
    public enum QualificationF
    {

        Male,
        Female
    }
}
