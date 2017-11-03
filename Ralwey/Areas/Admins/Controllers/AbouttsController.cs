using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ralwey.Models;

namespace Ralwey.Areas.Admins.Controllers
{
    public class AbouttsController : Controller
    {
        private RalweysEntities db = new RalweysEntities();

        // GET: Admins/Aboutts
        public ActionResult Index()
        {
            return View(db.Aboutt.ToList());
        }

        // GET: Admins/Aboutts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aboutt aboutt = db.Aboutt.Find(id);
            if (aboutt == null)
            {
                return HttpNotFound();
            }
            return View(aboutt);
        }

        // GET: Admins/Aboutts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admins/Aboutts/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,text")] Aboutt aboutt)
        {
            if (ModelState.IsValid)
            {
                db.Aboutt.Add(aboutt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aboutt);
        }

        // GET: Admins/Aboutts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aboutt aboutt = db.Aboutt.Find(id);
            if (aboutt == null)
            {
                return HttpNotFound();
            }
            return View(aboutt);
        }

        // POST: Admins/Aboutts/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,text")] Aboutt aboutt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aboutt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aboutt);
        }

        // GET: Admins/Aboutts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aboutt aboutt = db.Aboutt.Find(id);
            if (aboutt == null)
            {
                return HttpNotFound();
            }
            return View(aboutt);
        }

        // POST: Admins/Aboutts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aboutt aboutt = db.Aboutt.Find(id);
            db.Aboutt.Remove(aboutt);
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
