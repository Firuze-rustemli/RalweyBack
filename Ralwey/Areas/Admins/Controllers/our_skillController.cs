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
    public class our_skillController : Controller
    {
        private RalweysEntities db = new RalweysEntities();

        // GET: Admins/our_skill
        public ActionResult Index()
        {
            return View(db.our_skill.ToList());
        }

        // GET: Admins/our_skill/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            our_skill our_skill = db.our_skill.Find(id);
            if (our_skill == null)
            {
                return HttpNotFound();
            }
            return View(our_skill);
        }

        // GET: Admins/our_skill/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admins/our_skill/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,value")] our_skill our_skill)
        {
            if (ModelState.IsValid)
            {
                db.our_skill.Add(our_skill);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(our_skill);
        }

        // GET: Admins/our_skill/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            our_skill our_skill = db.our_skill.Find(id);
            if (our_skill == null)
            {
                return HttpNotFound();
            }
            return View(our_skill);
        }

        // POST: Admins/our_skill/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,value")] our_skill our_skill)
        {
            if (ModelState.IsValid)
            {
                db.Entry(our_skill).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(our_skill);
        }

        // GET: Admins/our_skill/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            our_skill our_skill = db.our_skill.Find(id);
            if (our_skill == null)
            {
                return HttpNotFound();
            }
            return View(our_skill);
        }

        // POST: Admins/our_skill/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            our_skill our_skill = db.our_skill.Find(id);
            db.our_skill.Remove(our_skill);
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
