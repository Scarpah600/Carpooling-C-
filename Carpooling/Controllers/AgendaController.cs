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
    public class AgendaController : Controller
    {
        private carpoolingEntities db = new carpoolingEntities();

        //
        // GET: /Agenda/

        public ActionResult Index()
        {
            var agenda = db.AGENDA.Include(a => a.DESTINO).Include(a => a.USUARIOS).Include(a => a.VEICULO);
            return View(agenda.ToList());
        }

        //
        // GET: /Agenda/Details/5

        public ActionResult Details(int id = 0)
        {
            AGENDA agenda = db.AGENDA.Find(id);
            if (agenda == null)
            {
                return HttpNotFound();
            }
            return View(agenda);
        }

        //
        // GET: /Agenda/Create

        public ActionResult Create()
        {
            ViewBag.DESTINOFINAL_DESTINOID = new SelectList(db.DESTINO, "ID", "ENDERECO");
            ViewBag.USUARIOPROPRIETARIO_ID = new SelectList(db.USUARIOS, "ID", "NOME");
            ViewBag.CARRO_CARROID = new SelectList(db.VEICULO, "ID", "MODELO");
            return View();
        }

        //
        // POST: /Agenda/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AGENDA agenda)
        {
            if (ModelState.IsValid)
            {
                db.AGENDA.Add(agenda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DESTINOFINAL_DESTINOID = new SelectList(db.DESTINO, "ID", "ENDERECO", agenda.DESTINOFINAL_DESTINOID);
            ViewBag.USUARIOPROPRIETARIO_ID = new SelectList(db.USUARIOS, "ID", "NOME", agenda.USUARIOPROPRIETARIO_ID);
            ViewBag.CARRO_CARROID = new SelectList(db.VEICULO, "ID", "MODELO", agenda.CARRO_CARROID);
            return View(agenda);
        }

        //
        // GET: /Agenda/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AGENDA agenda = db.AGENDA.Find(id);
            if (agenda == null)
            {
                return HttpNotFound();
            }
            ViewBag.DESTINOFINAL_DESTINOID = new SelectList(db.DESTINO, "ID", "ENDERECO", agenda.DESTINOFINAL_DESTINOID);
            ViewBag.USUARIOPROPRIETARIO_ID = new SelectList(db.USUARIOS, "ID", "NOME", agenda.USUARIOPROPRIETARIO_ID);
            ViewBag.CARRO_CARROID = new SelectList(db.VEICULO, "ID", "MODELO", agenda.CARRO_CARROID);
            return View(agenda);
        }

        //
        // POST: /Agenda/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AGENDA agenda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agenda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DESTINOFINAL_DESTINOID = new SelectList(db.DESTINO, "ID", "ENDERECO", agenda.DESTINOFINAL_DESTINOID);
            ViewBag.USUARIOPROPRIETARIO_ID = new SelectList(db.USUARIOS, "ID", "NOME", agenda.USUARIOPROPRIETARIO_ID);
            ViewBag.CARRO_CARROID = new SelectList(db.VEICULO, "ID", "MODELO", agenda.CARRO_CARROID);
            return View(agenda);
        }

        //
        // GET: /Agenda/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AGENDA agenda = db.AGENDA.Find(id);
            if (agenda == null)
            {
                return HttpNotFound();
            }
            return View(agenda);
        }

        //
        // POST: /Agenda/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AGENDA agenda = db.AGENDA.Find(id);
            db.AGENDA.Remove(agenda);
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