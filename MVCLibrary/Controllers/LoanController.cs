using MVCLibrary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCLibrary.Controllers
{
    public class LoanController : Controller
    {
        #region db
        DBLIBRARYEntities db=new DBLIBRARYEntities();
        #endregion
        public ActionResult Index()
        {
            return View();
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

        #region MyRegion

        #endregion
    }
}