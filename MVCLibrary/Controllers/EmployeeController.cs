using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLibrary.Models.Entities;
namespace MVCLibrary.Controllers
{
    public class EmployeeController : Controller
    {
        #region db
        DBLIBRARYEntities db = new DBLIBRARYEntities();
        #endregion
        public ActionResult Index()
        {
            var values= db.TBLEMPLOYEE.ToList();

            return View(values);
        }

        #region PersonelEkle
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(TBLEMPLOYEE parameter)
        {
            if (ModelState.IsValid)
            {
                return View("AddEmployee");
            }
            db.TBLEMPLOYEE.Add(parameter);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        #endregion

        #region RemoveEmployee
        public ActionResult RemoveEmployee(int id)
        {
            var prs = db.TBLEMPLOYEE.Find(id);
            db.TBLEMPLOYEE.Remove(prs);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion
        #region GetEmployee
        public ActionResult GetEmployee(int id)
        {
            var prs=db.TBLEMPLOYEE.Find(id);
            return View("GetEmployee", prs);
        }
        #endregion

        #region UpdateEmployee
        //[HttpPost]
        public ActionResult UpdateEmployee(TBLEMPLOYEE p)
        {
            var prs = db.TBLEMPLOYEE.Find(p.ID);
            prs.EMPLOYEE = p.EMPLOYEE;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion
    }
}