using MVCLibrary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLibrary.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        DBLIBRARY db=new DBLIBRARY();

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(TBLMEMBERS p)
        {
            if (!ModelState.IsValid)
            {
                return View("Register");
                        
            }
            db.TBLMEMBERS.Add(p);
            db.SaveChanges();   
            return View();  

            
        }
    }
}