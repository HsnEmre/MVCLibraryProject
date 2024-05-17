using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLibrary.Controllers
{
    public class MyPanelController : Controller
    {
        // GET: MyPanel
        [Authorize]

        public ActionResult Index()
        {
            return View();
        }
    }
}