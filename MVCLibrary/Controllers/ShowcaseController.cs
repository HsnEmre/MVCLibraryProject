using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLibrary.Models.Entities;
using MVCLibrary.Models.MyClasses;

namespace MVCLibrary.Controllers
{
    public class ShowcaseController : Controller
    {
        // GET: Showcase

        #region db
        DBLIBRARY db = new DBLIBRARY();
        #endregion
        [HttpGet]
        public ActionResult Index()
        {
            //var values = db.TBLBOOK.ToList();
            MC1 mc = new MC1();
            mc.value1 = db.TBLBOOK.ToList();
            mc.value2 = db.TBLABOUT.ToList();
            



            return View(mc);
        }


        #region MyRegion
        [HttpPost]
        public ActionResult Index(TBLCONNECTION t)
        {
            db.TBLCONNECTION.Add(t);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        #endregion










    }
}