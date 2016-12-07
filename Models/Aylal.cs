using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelWeb.Models
{
    public class Aylal
    {
        [Key]
        [Required]
        public int hutulburId { get; set; }
        [Required(ErrorMessage = "not name")]
        [Display(Name = "Aylal name")]
        public string name { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Chiglel")]
        public string chiglel { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Taniltsuulga")]
        public string taniltsuulga { get; set; }
        public string zurag { get; set; }
        public int hutuchId { get; set; }

    }
}