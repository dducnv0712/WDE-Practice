using StudentManage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAD.Models;

namespace WAD.Controllers
{
    public class HomeController : Controller
    {
        private MyDBContext myDBContext = new MyDBContext();
        public ActionResult Index()
        {
            var result = myDBContext.Exam.ToList();
            return View(result);
        } 
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "examSubject,startTime,examDate,examDuration,classRoom,facully")] Exam st)
        {
            if (ModelState.IsValid)
            {
                myDBContext.Exam.Add(st);
                myDBContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create");
        }

    }
}