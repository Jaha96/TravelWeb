using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelWeb.Controllers
{
    public class AdminController : Controller
    {
        public static List<SelectListItem> items = new List<SelectListItem>();
        public static SelectListItem[] getBloodType()
        {
            items.Clear();
            items.Add(new SelectListItem { Text = "O+", Value = "O+" });
            items.Add(new SelectListItem { Text = "O–", Value = "O–" });
            items.Add(new SelectListItem { Text = "A+", Value = "A+" });
            items.Add(new SelectListItem { Text = "A-", Value = "A-" });
            items.Add(new SelectListItem { Text = "B+", Value = "B+" });
            items.Add(new SelectListItem { Text = "B-", Value = "B-" });
            items.Add(new SelectListItem { Text = "AB+", Value = "AB+" });
            items.Add(new SelectListItem { Text = "AB-", Value = "AB-" });
            return items.ToArray();
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AylalRegister()
        {
            ViewBag.HutuchList = getBloodType();
            return View();
        }

        public ActionResult HutuchRegister()
        {
            return View();
        }
    }
}