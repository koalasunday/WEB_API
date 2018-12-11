using Electronic.DataAccess.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Electronic.Client.Controllers
{
    public class SuppliersController : Controller
    {
        // GET: Suppliers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuppliersParam suppliersParam)
        {
            return Json(JsonRequestBehavior.AllowGet);
        }
    }
}