using SecondPractMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondPractMVC.Controllers
{
    public class HomeController : Controller
    {
        List<Employee> emplist = new List<Employee>()
                {
                  new Employee(){Eid=1,EName="Shiva",Econtact=8080}
                };

        public ActionResult Edit()
        {
            return View(emplist);
        }

        public ActionResult MyEdit()
        {
            return View(emplist);
        }
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
    }
}