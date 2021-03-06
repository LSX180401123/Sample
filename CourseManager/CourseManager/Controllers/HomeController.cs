﻿using CourseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseManager.Controllers
{
    public class HomeController : Controller
    {
        private CourseManagerEntities db = new CourseManagerEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "你的应用程序说明页。";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "你的联系方式页。";

            return View();
        }
        [ChildActionOnly]
        public ActionResult Navbar()
        {
            var site = new WebsiteInfo();
            ViewBag.Site = site;
            return PartialView("~/Views/Shared/Navbar.cshtml");
        }

        [ChildActionOnly]
        public ActionResult SideBar()
        {
            var sidebars = db.SideBars.OrderBy(p => p.order);
            ViewBag.SideBars = sidebars.ToList();
            return PartialView("~/Views/Shared/SideBar.cshtml");
        }

    }
}
