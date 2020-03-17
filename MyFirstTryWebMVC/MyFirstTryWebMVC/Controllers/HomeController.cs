using MyFirstTryWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstTryWebMVC.Controllers
{
    public class HomeController : Controller
    {
        
       public ActionResult Index()
        {
            return View();
        }

      
            IList<Student> studentList = new List<Student>{
                            new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                            new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                            new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                            new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                            new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                            new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                            new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
                        };
        [HttpPost]
        public ActionResult Edit(Student std)
        {
            //write code to update student 

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var std = studentList.Where(s => s.StudentId == Id).FirstOrDefault();

            return View(std);
        }
           

        

     //  [HttpPost]
        public ActionResult mystr()
        {
            // return Content("Shiva Santosh KUmar");
            // return new RedirectResult("http://localhost:56650/Home/About");
            // return View("Index");
            // return Content( @"<h2>hello</h2>");
            return Content( DateTime.Now.ToString("T"));
        }
        
        public ActionResult Mystr()
        {
           // var id = Request.QueryString["id"];
            return Content("Good afternoon");
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