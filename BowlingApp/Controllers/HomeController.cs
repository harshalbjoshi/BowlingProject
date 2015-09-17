using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BowlingAppDBData;

namespace BowlingApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var x = new BowlingDBStoreEntities();

            x.Users.Add(new User { FirstName = "A", LastName = "B" });
            x.SaveChanges();


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