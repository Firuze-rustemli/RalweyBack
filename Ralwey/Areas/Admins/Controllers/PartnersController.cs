using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ralwey.Models;
using System.IO;

namespace Ralwey.Areas.Admins.Controllers
{
    public class PartnersController : Controller
    {
        private RalweysEntities db = new RalweysEntities();

        // GET: Admins/Partners
        public ActionResult Index()
        {
            return View(db.Partners.ToList());
        }

        // GET: Admins/Partners/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Partners partners = db.Partners.Find(id);
            if (partners == null)
            {
                return HttpNotFound();
            }
            return View(partners);
        }

        // GET: Admins/Partners/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admins/Partners/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,photo,link")] Partners partners)
        {

            var upload_file = HttpContext.Request.Files["photo"];

            if (upload_file.ContentType == "image/gif" || upload_file.ContentType == "image/png" || upload_file.ContentType == "image/jpg" || upload_file.ContentType == "image/jpeg")
            {
                string file_name = DateTime.Now.ToString("mm - ss - ffff - ") + upload_file.FileName;
                string new_file = Path.Combine(HttpContext.Server.MapPath("/Upload"), file_name);
                upload_file.SaveAs(new_file);
                partners.photo = file_name;
            }
            if (ModelState.IsValid)
            {
                db.Partners.Add(partners);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(partners);
        }
        // GET: Admins/Partners/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Partners partners = db.Partners.Find(id);
            if (partners == null)
            {
                return HttpNotFound();
            }
            return View(partners);
        }

        // POST: Admins/Partners/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,photo,link")] Partners partners )
        {
            if (ModelState.IsValid)
            {
                db.Entry(partners).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(partners);
        }


        // GET: Admins/Partners/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Partners partners = db.Partners.Find(id);
            if (partners == null)
            {
                return HttpNotFound();
            }
            return View(partners);
        }

        // POST: Admins/Partners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Partners partners = db.Partners.Find(id);
            db.Partners.Remove(partners);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
