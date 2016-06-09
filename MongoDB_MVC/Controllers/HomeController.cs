using MongoDB.Driver;
using MongoDB_MVC.App_Start;
using MongoDB_MVC.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MongoDB_MVC.Controllers
{
    public class HomeController : Controller
    {
        public RealEstateContext Context = new RealEstateContext();

        // GET: Home
        public ActionResult Index()
        {
            Context.Database.GetStats();
            return Json(Context.Database.Server.BuildInfo, JsonRequestBehavior.AllowGet);
            //return View();
        }
    }
}