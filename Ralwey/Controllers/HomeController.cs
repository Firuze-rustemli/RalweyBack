using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Ralwey.Models;

namespace Ralwey.Controllers
{
    public class HomeController : Controller
    {
        private RalweysEntities db = new RalweysEntities();

        public ActionResult Index()
        {
            ViewBag.slider = db.Slider.Find(3);
            ViewBag.services = db.Services.OrderBy(e => e.id).ToList();
            ViewBag.team = db.Terms.OrderBy(e => e.id).ToList();
            ViewBag.skill = db.our_skill.OrderBy(e => e.id).ToList();
            ViewBag.category = db.Categoru.OrderBy(e => e.id).ToList();
            ViewBag.works = db.Work.OrderBy(e => e.id).ToList();
            ViewBag.about = db.Aboutt.OrderBy(e => e.id).ToList();
            ViewBag.partner = db.Partners.OrderBy(e => e.id).ToList();
            ViewBag.plans = db.pricing_plans.OrderBy(e => e.id).ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactModels model)
        {
            if (ModelState.IsValid)
            {
                var body = new StringBuilder();
                body.AppendLine("Ad/Soyad: " + model.fullname);
                body.AppendLine("Email: " + model.email);
                body.AppendLine("Mesaj: " + model.text);
                Gmail.SendMail(body.ToString());
                ViewBag.Success = true;
            }
            ViewBag.setting = db.Setting.Find(1);
            return View();
        }



    }
}