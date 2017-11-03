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
    public class CategorusController : Controller
    {
        private RalweysEntities db = new RalweysEntities();

        // GET: Admins/Categorus
        public ActionResult Index()
        {
            return View(db.Categoru.ToList());
        }

        // GET: Admins/Categorus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoru categoru = db.Categoru.Find(id);
            if (categoru == null)
            {
                return HttpNotFound();
            }
            return View(categoru);
        }

        // GET: Admins/Categorus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admins/Categorus/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name")] Categoru categoru)
        {
            if (ModelState.IsValid)
            {
                db.Categoru.Add(categoru);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoru);
        }

        // GET: Admins/Categorus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoru categoru = db.Categoru.Find(id);
            if (categoru == null)
            {
                return HttpNotFound();
            }
            return View(categoru);
        }

        // POST: Admins/Categorus/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name")] Categoru categoru)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoru).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoru);
        }

        // GET: Admins/Categorus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoru categoru = db.Categoru.Find(id);
            if (categoru == null)
            {
                return HttpNotFound();
            }
            return View(categoru);
        }

        // POST: Admins/Categorus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Categoru categoru = db.Categoru.Find(id);
            db.Categoru.Remove(categoru);
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
