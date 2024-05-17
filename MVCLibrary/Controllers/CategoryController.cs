using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLibrary.Models.Entities;


namespace MVCLibrary.Controllers
{



    public class CategoryController : Controller
    {
        #region DB
        DBLIBRARY db = new DBLIBRARY();
        #endregion

        // GET: Category
        public ActionResult Index()
        {
            var values = db.TBLCATEGORY.ToList();

            return View(values);
        }

        #region AddCategory
        #region addcategoryget
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        #endregion
        #region addcategorypost
        [HttpPost]
        public ActionResult AddCategory(TBLCATEGORY categoryParameter)
        {
            if (!ModelState.IsValid)
            {
                return View("Addcategory");
            }
            else
            {
                db.TBLCATEGORY.Add(categoryParameter);
                db.SaveChanges();
                //return RedirectToAction("Index");
                return View();
            }
        }
        #endregion

        #endregion


        #region RemoveCategory
        public ActionResult RemoveCategory(int id)
        {
            var category=db.TBLCATEGORY.Find(id);
            db.TBLCATEGORY.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        #endregion


        #region GetCategory
       public ActionResult GetCategories(int id)
        {
            var dtg=db.TBLCATEGORY.Find(id);

            return View("GetCategories",dtg);
        }
        #endregion

        #region updateCategory
        public ActionResult UpdateCategory(TBLCATEGORY p)
        {
            var ctg=db.TBLCATEGORY.Find(p.CATEGORYID);
            ctg.NAME=p.NAME;
            db.SaveChanges();
            return RedirectToAction("Index");                   
        }
        #endregion
    }
}