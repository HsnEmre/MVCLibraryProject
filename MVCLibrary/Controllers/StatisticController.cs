using MVCLibrary.Models.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLibrary.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic

        #region db
        DBLIBRARY db = new DBLIBRARY();
        #endregion
        public ActionResult Index()
        {
            var deger1 = db.TBLMEMBERS.Count();
            var deger2 = db.TBLBOOK.Count();
            var deger3 = db.TBLBOOK.Where(x => x.SITUATION == false).Count();
            var deger4 = db.TBLPUNISHMENT.Sum(x => x.MONEY);
            ViewBag.dgr1 = deger1;
            ViewBag.dgr2 = deger2;
            ViewBag.dgr3 = deger3;
            ViewBag.dgr4 = deger4;
            return View();
        }

        #region Weather
        public ActionResult Weather()
        {
            return View();
        }

        #endregion

        #region WeatherCart
        public ActionResult WeatherCart()
        {
            return View();
        }

        #endregion

        #region Gallery

        public ActionResult Gallery()
        {
            return View();
        }

        #endregion
        #region UploadPicture
        [HttpPost]
        public ActionResult UploadPic(HttpPostedFileBase file)
        {
            if (file.ContentLength>0)
            {
                string filepath = Path.Combine(Server.MapPath("~/web2/resimler"), Path.GetFileName(file.FileName));
                file.SaveAs(filepath);
                
            }
            return RedirectToAction("Gallery");
        }
        #endregion



        #region lİNQCart

        public ActionResult LinqCart()
        {
            var deger1 = db.TBLBOOK.Count();
            var deger2 = db.TBLMEMBERS.Count();
            var deger3 = db.TBLPUNISHMENT.Sum(x => x.MONEY);
            var deger4 = db.TBLBOOK.Where(x => x.SITUATION == false).Count();
            var deger5 = db.TBLCATEGORY.Count();
            var deger8 = db.EnFazlaKitapYazar().FirstOrDefault();
            var deger9 = db.TBLBOOK.GroupBy(x => x.PUBLISHER).OrderByDescending(z => z.Count()).Select(y => new { y.Key }).FirstOrDefault();
            var deger11 = db.TBLCONNECTION.Count();

            ViewBag.dgr1 = deger1;
            ViewBag.dgr2 = deger2;
            ViewBag.dgr3 = deger3;
            ViewBag.dgr4 = deger4;
            ViewBag.dgr5 = deger5;
            ViewBag.dgr8 = deger8;
            ViewBag.dgr9 = deger9;
            ViewBag.dgr11 = deger11;




            return View();
        }

        #endregion

    }
}