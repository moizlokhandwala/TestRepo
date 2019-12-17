﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Booking information management system";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Info";

            return View();
        }
    }
}