using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelWeb.Models.DB;
using TravelWeb.Models.EntityManager;
using TravelWeb.Models.ViewModel;

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
        [HttpPost]
        public ActionResult HutuchRegister(HutuchModel HM)
        {
            HutuchManager manag = new HutuchManager();
            string ret= manag.AddUserAccount(HM);
            if (ret == "1")
            {
                ViewBag.Message = "Амжилттай нэмэгдлээ";
            }
            else {
                ViewBag.ErrorMessage = "Алдаа гарлаа";
            }
            return View();
        }
        private Database1Entities db = new Database1Entities();
        public ActionResult HutuchList()
        {
            return View(db.Hutuches.ToList());
        }
        public ActionResult DetailsHutuch(string id = null)
        {

            Hutuch hut = db.Hutuches.Find(Convert.ToInt32(id));
            if (hut == null)
            {
                return HttpNotFound();
            }
            return View(hut);
        }
    }
}