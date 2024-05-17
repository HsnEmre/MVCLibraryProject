using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLibrary.Models.Entities;

namespace MVCLibrary.Controllers
{
    public class BookController : Controller
    {
        DBLIBRARY db = new DBLIBRARY();
        public ActionResult Index(string parameter)
        {
            var books = from k in db.TBLBOOK select k;
            if (!string.IsNullOrEmpty(parameter))
            {
                books = books.Where(m=>m.NAME.Contains(parameter));
            }

            //var books = db.TBLBOOK.ToList();
            return View(books.ToList());
        }

        #region addBook

        [HttpGet]
        public ActionResult AddBook()
        {
            List<SelectListItem> val1 = (from i in db.TBLCATEGORY.ToList()
                                         select new SelectListItem
                                         {
                                             Text = i.NAME,
                                             Value = i.CATEGORYID.ToString()
                                         }).ToList();

            List<SelectListItem> val2 = (from i in db.TBLAUTHOR.ToList()
                                         select new SelectListItem
                                         {
                                             Text = i.NAME + " " + i.SURNAME,
                                             Value = i.ID.ToString()
                                         }).ToList();

            ViewBag.dgr = val1;
            ViewBag.dgr2 = val2;

            return View();
        }
        [HttpPost]
        public ActionResult AddBook(TBLBOOK parameter)
        {
            List<SelectListItem> val1 = (from i in db.TBLCATEGORY.ToList()
                                         select new SelectListItem
                                         {
                                             Text = i.NAME,
                                             Value = i.CATEGORYID.ToString()
                                         }).ToList();

            List<SelectListItem> val2 = (from i in db.TBLAUTHOR.ToList()
                                         select new SelectListItem
                                         {
                                             Text = i.NAME + " " + i.SURNAME,
                                             Value = i.ID.ToString()
                                         }).ToList();

            ViewBag.dgr = val1;
            ViewBag.dgr2 = val2;
            if (!ModelState.IsValid)
            {
                return View("AddBook");
            }
            else
            {
                var categories = db.TBLCATEGORY.Where(x => x.CATEGORYID == parameter.TBLCATEGORY.CATEGORYID).FirstOrDefault();
                var author = db.TBLAUTHOR.Where(x => x.ID == parameter.TBLAUTHOR.ID).FirstOrDefault();
                parameter.TBLCATEGORY = categories;
                parameter.TBLAUTHOR = author;
                db.TBLBOOK.Add(parameter);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            
        }
        #endregion

        #region RemoveKitap
        public ActionResult RemoveBook(int id)
        {
            var book = db.TBLBOOK.Find(id);
            db.TBLBOOK.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        #region GetBook
        public ActionResult GetBook(int id)
        {
            List<SelectListItem> val1 = (from i in db.TBLCATEGORY.ToList()
                                         select new SelectListItem
                                         {
                                             Text = i.NAME,
                                             Value = i.CATEGORYID.ToString()
                                         }).ToList();
            ViewBag.dgr3 = val1;

            List<SelectListItem> val2 = (from i in db.TBLAUTHOR.ToList()
                                         select new SelectListItem
                                         {
                                             Text = i.NAME + " " + i.SURNAME,
                                             Value = i.ID.ToString()
                                         }).ToList();
            ViewBag.dgr4 = val2;
            var book = db.TBLBOOK.Find(id);

            return View("GetBook", book);

        }
        #endregion

        #region UpdateBook
        public ActionResult UpdateBook(TBLBOOK parameter)
        {
            var book = db.TBLBOOK.Find(parameter.ID);
            book.NAME = parameter.NAME;
            book.NAME = parameter.NAME;
            book.PUBLICYEAR = parameter.PUBLICYEAR;
            book.SHEET = parameter.SHEET;
            book.PUBLISHER = parameter.PUBLISHER;
            book.SITUATION = true;

            var ctg = db.TBLCATEGORY.Where(x => x.CATEGORYID == parameter.TBLCATEGORY.CATEGORYID).FirstOrDefault();
            var auth = db.TBLAUTHOR.Where(x => x.ID == parameter.TBLAUTHOR.ID).FirstOrDefault();
            book.CATEGORY = ctg.CATEGORYID;
            book.AUTHOR = auth.ID;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        #region SearchBook


        #endregion
    }
}