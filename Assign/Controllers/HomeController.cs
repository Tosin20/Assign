using Assign.Models.DatabaseModel;
using Assign.Models.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assign.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User newstaff)
        {
            try

            {
                var db = new Model1();
                var st = new User();
                st.StaffName = newstaff.StaffName;
                st.StaffEmail = newstaff.StaffEmail;
                
                db.Set<User>().Add(st);
                db.SaveChanges();
                return View();
                return RedirectToAction("SuccessfulR");
            }


            catch (Exception Ex)
            {
                ViewBag.ErrorMessage = "Unsuccessful registration";
                return View();
            }
        }
            public ActionResult SuccessfulR()
            {
                return View();
            }

    }
}