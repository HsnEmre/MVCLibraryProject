﻿using System;
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
        DBLIBRARYEntities db = new DBLIBRARYEntities();
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
            db.TBLCATEGORY.Add(categoryParameter);
            db.SaveChanges();
            //return RedirectToAction("Index");
            return View();
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
    }
}