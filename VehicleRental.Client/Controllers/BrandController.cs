using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleRental.Service;

namespace VehicleRental.Client.Controllers
{
    public class BrandController : Controller
    {
        IBrandService service;

        public BrandController(IBrandService service)
        {
            this.service = service;
        }

        // GET: Brand
        public ActionResult Index()
        {
            return View();
        }

        // Get list Brand
        public ActionResult GetList()
        {
            return Json(service.GetAll(), JsonRequestBehavior.AllowGet);
        }
    }
}