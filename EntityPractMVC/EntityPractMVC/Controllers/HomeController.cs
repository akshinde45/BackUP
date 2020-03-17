using EntityPractMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace EntityPractMVC.Controllers
{
    public class HomeController : Controller
    {
        private NewDbContext db = new NewDbContext();
        public ActionResult Index()
        {
            return View(db.employees.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Employee employee)
        {
            //[Bind(Include = "Eid, Ename,Designation")]
            if (ModelState.IsValid)
            {
                db.employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
            
        }

        //...............Edit the Data .............
        public ActionResult Edit(int? id)
        {
            if(id ==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.employees.Find(id);
            if(employee ==null)
            {
                return HttpNotFound();
            }
                return View(employee);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Eid, Ename,Designation")]Employee employee)
        {

            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);

        }
        //.....................................................................................
        public HttpStatusCodeResult NotFound()
        {
            return HttpNotFound("Not Found");
        }

        public HttpStatusCodeResult Unauthorized()
        {
            return new HttpStatusCodeResult(HttpStatusCode.Unauthorized, "you are not autjotized");
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