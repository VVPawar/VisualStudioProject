using SimpleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            Student model = new Student();
            model.Religion = getReligion();

            model.AcademicYear = getAcademicYear();
            model.ClassName = getClassName();
            model.StudentType = getStudentType();
            model.Nationality = getNationality();
            return View(model);
        }
        [HttpPost]
        public ActionResult Subscribe(Student model)
        {
            if (!ModelState.IsValid)
            {
                if (model.StudentType == null) {
                    model.StudentType = getStudentType();
                }
                model.Religion = getReligion();

                model.AcademicYear = getAcademicYear();
                model.ClassName = getClassName();
                model.StudentType = getStudentType();
                model.Nationality = getNationality();
                return View("Index", model);
            }

            return View("Index", model);
        }
        [Route("Home/About/{name: String?}")]
        public ActionResult About(String name)
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private List<SelectListItem> getAcademicYear()
        {
            List<SelectListItem> AcademicYear = new List<SelectListItem>();
            AcademicYear.Add(new SelectListItem { Text = "2021-22", Value = "2021-22" });
            AcademicYear.Add(new SelectListItem { Text = "2022-23", Value = "2022-23" });
            return AcademicYear;
        }
        private List<SelectListItem> getNationality()
        {
            List<SelectListItem> Nationality = new List<SelectListItem>();
            Nationality.Add(new SelectListItem { Text = "INDIAN", Value = "INDIAN" });
            Nationality.Add(new SelectListItem { Text = "AFGHAN", Value = "AFGHAN" });
            Nationality.Add(new SelectListItem { Text = "ALBANIAM", Value = "ALBANIAM" });
            Nationality.Add(new SelectListItem { Text = "ALGERIAN", Value = "ALGERIAN" });
            Nationality.Add(new SelectListItem { Text = "AMERICAN", Value = "AMERICAN" });
            Nationality.Add(new SelectListItem { Text = "AUSTRALIAN", Value = "AUSTRALIAN" });
            Nationality.Add(new SelectListItem { Text = "AUSTRIAN", Value = "AUSTRIAN" });
            return Nationality;
        }
        private List<SelectListItem> getStudentType()
        {
            List<SelectListItem> StudentType = new List<SelectListItem>();
            StudentType.Add(new SelectListItem { Text = "DAY SCHOLAR", Value = "DAY_SCHOLAR" });
            StudentType.Add(new SelectListItem { Text = "HOSTEL", Value = "HOSTEL" });
            return StudentType;
        }
        private List<SelectListItem> getClassName()
        {
            List<SelectListItem> ClassName = new List<SelectListItem>();
            ClassName.Add(new SelectListItem { Text = "NURSERY(2021-22)", Value = "NURSERY" });
            ClassName.Add(new SelectListItem { Text = "KG(2021-22)", Value = "KG" });
            ClassName.Add(new SelectListItem { Text = "CLASS-|(2021-22)", Value = "CLASS-|" });
            ClassName.Add(new SelectListItem { Text = "CLASS-||(2021-22)", Value = "CLASS-||" });
            ClassName.Add(new SelectListItem { Text = "CLASS-|||(2021-22)", Value = "CLASS-|||" });
            ClassName.Add(new SelectListItem { Text = "CLASS-|V(2021-22)", Value = "CLASS-|V" });
            ClassName.Add(new SelectListItem { Text = "CLASS-V(2021-22)", Value = "CLASS-V" });
            ClassName.Add(new SelectListItem { Text = "CLASS-V|(2021-22)", Value = "CLASS-V|" });
            ClassName.Add(new SelectListItem { Text = "CLASS-V||(2021-22)", Value = "CLASS-V||" });
            ClassName.Add(new SelectListItem { Text = "CLASS-V|||(2021-22)", Value = "CLASS-V|||" });
            ClassName.Add(new SelectListItem { Text = "CLASS-|X(2021-22)", Value = "CLASS-|X" });
            ClassName.Add(new SelectListItem { Text = "CLASS-X(2021-22)", Value = "CLASS-X" });
            ClassName.Add(new SelectListItem { Text = "CLASS-X|(2021-22)", Value = "CLASS-X|" });
            ClassName.Add(new SelectListItem { Text = "CLASS-V|(HOSTEL)2021-22", Value = "CLASS-V|HOSTEL" });
            ClassName.Add(new SelectListItem { Text = "CLASS-V||(HOSTEL)2021-22", Value = "CLASS-V||HOSTEL" });
            ClassName.Add(new SelectListItem { Text = "CLASS-V|||(HOSTEL)2021-22", Value = "CLASS-V|||HOSTEL" });
            ClassName.Add(new SelectListItem { Text = "CLASS-|X(HOSTEL)2021-22", Value = "CLASS-|XHOSTEL" });
            ClassName.Add(new SelectListItem { Text = "CLASS-X(HOSTEL)2021-22", Value = "CLASS-XHOSTEL" });
            ClassName.Add(new SelectListItem { Text = "CLASS-X|(HOSTEL)2021-22", Value = "CLASS-X|HOSTEL" });
            return ClassName;
        }
        private List<SelectListItem> getReligion()
        {
            List<SelectListItem> Religion = new List<SelectListItem>();
            Religion.Add(new SelectListItem { Text = "Hindu", Value = "Hindu" });
            Religion.Add(new SelectListItem { Text = "Muslim", Value = "Muslim" });
            Religion.Add(new SelectListItem { Text = "Sikh", Value = "Sikh" });
            Religion.Add(new SelectListItem { Text = "Chrisrian", Value = "Chrisrian" });
            Religion.Add(new SelectListItem { Text = "Buddhist", Value = "Buddhist" });
            Religion.Add(new SelectListItem { Text = "Jainism", Value = "Jainism" });
            Religion.Add(new SelectListItem { Text = "Others", Value = "Others" });
            return Religion;
        }
    }
}