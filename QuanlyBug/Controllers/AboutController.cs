﻿using QuanlyBug.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanlyBug.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        private QuanlyBugEntities db = new QuanlyBugEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test_Data()
        {
            return View();
        }
    }
}