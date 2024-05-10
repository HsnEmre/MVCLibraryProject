using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLibrary.Models.Entities;

namespace MVCLibrary.Controllers
{
    public class AuthorController : Controller
    {
        DBLIBRARYEntities db = new DBLIBRARYEntities();
        public ActionResult Index()
        {
            var values = db.TBLAUTHOR.ToList();

            return View(values);
        }

        #region AddAuthor
        [HttpGet]
        public ActionResult AddAuthor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAuthor(TBLAUTHOR parameter)
        {
            db.TBLAUTHOR.Add(parameter);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        #endregion

        #region RemoveAuthor
        public ActionResult RemoveAuthor(int id)
        {
            var author = db.TBLAUTHOR.Find(id);
            db.TBLAUTHOR.Remove(author);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        #region GetAuthor
        public ActionResult GetAuthor(int id)
        {
            var auth = db.TBLAUTHOR.Find(id);
            return View("GetAuthor", auth);
        }
        #endregion

        #region UpdateAuthor
        public ActionResult UpdateAuthor(TBLAUTHOR parameter)
        {
            var auth = db.TBLAUTHOR.Find(parameter.ID);
            auth.NAME=parameter.NAME;
            auth.SURNAME = parameter.SURNAME;
            auth.DETAİL = parameter.DETAİL;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

    }
}