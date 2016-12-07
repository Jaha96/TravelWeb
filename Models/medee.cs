using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelWeb.Models
{
    public class medee
    {
        public string Medeeid{get; set;}
        public string zurag { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Text")]
        public string text { get; set; }
    }
}