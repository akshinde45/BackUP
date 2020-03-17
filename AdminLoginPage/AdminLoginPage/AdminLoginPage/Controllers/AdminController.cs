using AdminLoginPage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AdminLoginPage.Controllers
{
    public class AdminController : Controller
    {
        AdminDBContext AdminDB = new AdminDBContext();

       
        
        //This is goes to the first login page of Admin
        // GET: Admin
        public ActionResult AdminPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminPage(AdminLoginPage.Models.AdminLogin AdminLogins)
        {

            using (AdminDBContext ad = new AdminDBContext())
            {
             //   var userdetail = ad.AdminLogins.Where(m => m.username == AdminLogins.username && m.password == AdminLogins.password).FirstOrDefault();
                var userdetail = ad.adminLogins.Where(m => m.username == AdminLogins.username && m.password == AdminLogins.password).FirstOrDefault();

                if (userdetail ==null)
                {
                    AdminLogins.LoginErrorMessage = "Wrong username";
                    return View("AdminPage", AdminLogins);
                }
                else
                {
                    return RedirectToAction("AdminLogin", "Admin");
                }
            }

            return View("AdminLogin");
        }

        //Functionalities of Admin


        public ActionResult AdminLogin()
        {
            return View();
        }

        
        
       public ActionResult Admin_ShowBook()
        {
            return View(AdminDB.AdminAddBooks.ToList());
        }
      /*  [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Admin_ShowBook(AdminLogin AdminLogins)
        {
            return View(AdminLogins);
        }*/

        //Add the Book

        public ActionResult AddBook()
        {
            return View("AddBook");
        }

        [HttpPost]
        public ActionResult AddBook(AdminAddBook Adaddbook)
        {
            //[Bind(Include = "Eid, Ename,Designation")]
            if (ModelState.IsValid)
            {
                AdminDB.AdminAddBooks.Add(Adaddbook);
                AdminDB.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Adaddbook);

        }

        //Find the Book

        public ActionResult AdminFindBook(string Searchby, string search)
        {
            if (Searchby == "Book_Name")
            {
                var model = AdminDB.AdminAddBooks.Where(book => book.Book_Name == search || search == null).ToList();
                return View(model);

            }
            else
            {
                var model = AdminDB.AdminAddBooks.Where(book => book.author.StartsWith(search) || search == null).ToList();
                return View(model);
            }
        }


        //Edit the Book....update

        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminAddBook adminAddBook = AdminDB.AdminAddBooks.Find(id);
            if(adminAddBook ==null)
            {
                return HttpNotFound();
            }
            return View(adminAddBook);
        }
        [HttpPost]
        public ActionResult Edit(AdminAddBook adminAddBook)
        {

            if (ModelState.IsValid)
            {
                AdminDB.Entry(adminAddBook).State = EntityState.Modified;
                AdminDB.SaveChanges();
                return RedirectToAction("Admin_ShowBook");
            }
            return View(adminAddBook);
        }

        //Details of the Books
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminAddBook adminAddBook = AdminDB.AdminAddBooks.Find(id);
            if (adminAddBook == null)
            {
                return HttpNotFound();
            }
            return View(adminAddBook);
        }

        //Delete the Book
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminAddBook adminAddBook = AdminDB.AdminAddBooks.Find(id);
            if (adminAddBook == null)
            {
                return HttpNotFound();
            }
            return View(adminAddBook);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
             AdminAddBook adminAddBook= AdminDB.AdminAddBooks.Find(id);
            AdminDB.AdminAddBooks.Remove(adminAddBook);
            AdminDB.SaveChanges();
            return RedirectToAction("Admin_ShowBook");

        }





    }
}