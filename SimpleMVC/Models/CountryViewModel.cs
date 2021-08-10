using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC.Models
{
    public class CountryViewModel
    {
        [Display(Name = "Country")]
        [Required(ErrorMessage = "{0} is required.")]
        public int SelectedCountryId { get; set; }

        public IList<SelectListItem> AvailableCountries { get; set; }

        public CountryViewModel()
        {
            AvailableCountries = new List<SelectListItem>();
        }
    }
}