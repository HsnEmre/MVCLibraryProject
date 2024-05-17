using MVCLibrary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;


namespace MVCLibrary.Controllers
{
    public class LoanController : Controller
    {
        #region db
        DBLIBRARY db = new DBLIBRARY();
        #endregion
        public ActionResult Index()
        {
            var values = db.TBLMOVE.Where(x=>x.PROCESSSITUATION==false).ToList();
            return View(values);
        }

        #region Loan
        [HttpGet]
        public ActionResult Loan()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Loan(TBLMOVE paraeter)
        {
            db.TBLMOVE.Add(paraeter);
            db.SaveChanges();
            return View();
        }

        #endregion

        #region LoanGivingBack

        public ActionResult LoanGivingBack(TBLMOVE parameter)
        {
            var ln = db.TBLMOVE.Find(parameter.ID);

            DateTime d1 = DateTime.Parse(ln.ISSUEDATE.ToString());
            DateTime d2 = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            TimeSpan d3 = d2 - d1;

            ViewBag.dgr = d3.TotalDays;

            return View("LoanGivingBack", ln);

        }

        #endregion


        #region UpdateLoan
        public ActionResult UpdateLoan(TBLMOVE parameter)
        {
            var move = db.TBLMOVE.Find(parameter.ID);
            move.GETMEMBERDATE = parameter.GETMEMBERDATE;
            move.PROCESSSITUATION = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion
    }
}