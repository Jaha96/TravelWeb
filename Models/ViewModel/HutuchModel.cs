using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelWeb.Models.ViewModel
{
    public class HutuchModel
    {
        public int hutuchId { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Hutuch name")]
        public string name { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "email")]
        public string email { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "register No")]
        public string registerNo { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "phone")]
        public string phone { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Password")]
        public string password { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Address")]
        public string address { get; set; }
        public DateTime birthDate { get; set; }
        public bool gender { get; set; }
    }
}