using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Carpooling.Models;

namespace Carpooling.Controllers
{
    public class DestinoController : Controller
    {
        private carpoolingEntities db = new carpoolingEntities();

        //
        // GET: /Destino/

        public ActionResult Index()
        {
            return View(db.DESTINO.ToList());
        }

        //
        // GET: /Destino/Details/5

        public ActionResult Details(int id = 0)
        {
            DESTINO destino = db.DESTINO.Find(id);
            if (destino == null)
            {
                return HttpNotFound();
            }
            return View(destino);
        }

        //
        // GET: /Destino/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Destino/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DESTINO destino)
        {
            if (ModelState.IsValid)
            {
                db.DESTINO.Add(destino);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(destino);
        }

        //
        // GET: /Destino/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DESTINO destino = db.DESTINO.Find(id);
            if (destino == null)
            {
                return HttpNotFound();
            }
            return View(destino);
        }

        //
        // POST: /Destino/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DESTINO destino)
        {
            if (ModelState.IsValid)
            {
                db.Entry(destino).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(destino);
        }

        //
        // GET: /Destino/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DESTINO destino = db.DESTINO.Find(id);
            if (destino == null)
            {
                return HttpNotFound();
            }
            return View(destino);
        }

        //
        // POST: /Destino/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DESTINO destino = db.DESTINO.Find(id);
            db.DESTINO.Remove(destino);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}