using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLibrary.Models.Entities;
using PagedList;
using PagedList.Mvc;


namespace MVCLibrary.Controllers
{
    public class MemberController : Controller
    {
        #region DB
        DBLIBRARYEntities db=new DBLIBRARYEntities();
        #endregion
        public ActionResult Index(int sayfa=1)
        {
            //var values = db.TBLMEMBERS.ToList();
            var values = db.TBLMEMBERS.ToList().ToPagedList(sayfa, 10);
            return View(values);
        }

        #region AddMember
        [HttpGet]
        public ActionResult AddMember()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMember(TBLMEMBERS parameter)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            db.TBLMEMBERS.Add(parameter);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        #endregion

        #region RemoveMember
        public ActionResult RemoveMember(int id)
        {
            var member = db.TBLMEMBERS.Find(id);
            db.TBLMEMBERS.Remove(member);   
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        #endregion


        #region GetMember
        public ActionResult GetMember(int id)
        {
            var member=db.TBLMEMBERS.Find(id);
            return View("GetMember", member);
        }
        #endregion

        #region UpdateMember
        public ActionResult UpdateMembers(TBLMEMBERS parameters)
        {
            var member = db.TBLMEMBERS.Find(parameters.ID);
            member.NAME = parameters.NAME;
            member.SURNAME= parameters.SURNAME;
            member.NICKNAME= parameters.NICKNAME;
            member.MAIL= parameters.MAIL;
            member.PHOTGHRAPH= parameters.PHOTGHRAPH;
            member.PASSWORD=member.PASSWORD;
            member.PHONENUMBER=parameters.PHONENUMBER;
            member.SCHOOL=  parameters.SCHOOL;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

    }
}