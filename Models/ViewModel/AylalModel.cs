using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelWeb.Models.ViewModel
{
    public class AylalModel
    {
        public int hutulburId { get; set; }
        public string name { get; set; }
        public string chiglel { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string taniltsuulga { get; set; }
        public string zurag { get; set; }
        public int hutuchId { get; set; }
    }
}