using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VehicleRental.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HttpCookie cookie = System.Web.HttpContext.Current.Request.Cookies["IsRole"];
            if (cookie != null && cookie.Value != null)
            {
                if(cookie.Value == "Admin") return this.Redirect("~/admin/index");
                if (cookie.Value == "User") return this.Redirect("~/user/index");
            }
                
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
    }
}