using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC.Models
{
    public class Student
    {
        public Student() {
            StudentType = new List<SelectListItem>();
            Religion = new List<SelectListItem>();
            Nationality = new List<SelectListItem>();
            
            ClassName = new List<SelectListItem>();
            AcademicYear = new List<SelectListItem>();
        }
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Student Name is Required")]
        public String StudentName { get; set; }
        [Required(ErrorMessage = "Student Last Name is Required")]
        public String L_Name { get; set; }
        [Required(ErrorMessage = "Date of Birth is Required")]
        public String DOB { get; set; }

        public String MotherT { get; set; }
        [Required(ErrorMessage = "Mobile Number is Required")]
        public String Mobile { get; set; }
        public String MiddleName { get; set; }
        public String Phone { get; set; }
        public String PreviousSchool { get; set; }
        [Required(ErrorMessage = "Email id is Required")]
        public String Email { get; set; }
        public String photo { get; set; }

        public int Age { get; set; }
        [Required(ErrorMessage = "Student Type is Required")]
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

        [Required(ErrorMessage = "Nationality Required")]
        [DisplayName("Nationality")]
        public List<SelectListItem> Nationality
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Gender Required")]
        [DisplayName("Gender")]
        public Gender StudentGender { get; set; }
 
   

        [Required(ErrorMessage = "Class  Required")]
        [DisplayName("ClassName")]
        public List<SelectListItem> ClassName
        {
            get;
            set;
        }

        [Required(ErrorMessage = "AcademicYear Required")]
        [DisplayName("AcademicYear")]
        public List<SelectListItem> AcademicYear
        {
            get;
            set;
        }
    }
    public enum Gender
    {
        Male,
        Female
    }

}