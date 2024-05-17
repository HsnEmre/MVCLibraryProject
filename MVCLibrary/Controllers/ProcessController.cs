using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLibrary.Models.Entities;

namespace MVCLibrary.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        #region db
        DBLIBRARY db = new DBLIBRARY();
        #endregion
        public ActionResult Index()
        {
            var values = db.TBLMOVE.Where(x => x.PROCESSSITUATION == true).ToList();
            return View(values);
        }
    }
}