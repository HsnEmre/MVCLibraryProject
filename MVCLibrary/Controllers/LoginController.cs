using MVCLibrary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc;
using System.Web.Security;


namespace MVCLibrary.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        DBLIBRARY db = new DBLIBRARY();

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(TBLMEMBERS p)
        {

            var values = db.TBLMEMBERS.FirstOrDefault(x => x.MAIL == p.MAIL && x.PASSWORD == p.PASSWORD);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.MAIL, false);
                Session["Ad"] = values.NAME.ToString();
                Session["Soyad"] = values.SURNAME.ToString();
                Session["Kullanıcı Adı"] = values.NICKNAME.ToString();
                Session["Okul"] = values.SCHOOL.ToString();
                Session["Telefon"] = values.PHONENUMBER.ToString();
                Session["Şifre"] = values.PASSWORD.ToString();
                return RedirectToAction("Index", "MyPanel");
            }
            else
            {

                return View();
            }

        }
    }
}