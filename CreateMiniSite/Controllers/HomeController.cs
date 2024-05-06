using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreateMiniSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string name,string category,int price)
        {
            ViewBag.Name     = name;
            ViewBag.Category = category;
            ViewBag.Price    = price;
            return View();
        }
    }
}