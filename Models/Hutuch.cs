using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelWeb.Models
{
    public class Hutuch
    {
        public int hutuchId { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string registerNo { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public DateTime birthDate { get; set; }
        public bool gender { get; set; }
    }
}