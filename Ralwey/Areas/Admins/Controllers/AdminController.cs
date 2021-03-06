﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ralwey.Models;

namespace Ralwey.Areas.Admins.Controllers
{
    public class AdminController : Controller
    {
        private RalweysEntities db = new RalweysEntities();
        // GET: Admins/Admin
        public ActionResult Index()
        {
            if (Session["admin"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("login");
            }

        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin adm)
        {
            if (adm.username != null && adm.password != null)
            {
                Admin admin = db.Admin.FirstOrDefault(a => a.username == adm.username && a.password == adm.password);
                if (admin != null)
                {
                    Session["admin"] = true;
                    return RedirectToAction("index", "admin");
                }
                else
                {
                    Session["error_input"] = "Username ve ya password yalnisdir";
                    return RedirectToAction("login");
                }
            }
            else
            {
                Session["error_message"] = "Bosluq buraxma";
                return RedirectToAction("login");
            }

        }

        public ActionResult Logout()
        {
            //Session["admin"] = null;
            Session.Clear();
            return RedirectToAction("login", "admin");
        }
    }
}