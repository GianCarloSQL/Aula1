using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MercadoTech.Model;

namespace WebApplication4.Controllers
{
    public class ColaboradorsController : Controller
    {
        private Context db = new Context();

        // GET: Colaboradors
        public ActionResult Index()
        {
            return View(db.Colaborador.ToList());
        }

        // GET: Colaboradors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colaborador colaborador = db.Colaborador.Find(id);
            if (colaborador == null)
            {
                return HttpNotFound();
            }
            return View(colaborador);
        }

        // GET: Colaboradors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Colaboradors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Email,Is_PCD,ForneceCarona,ResideBlumenau,Trabalho_Noturno,Data_Nascimento,Ativo,UsuarioCriacao,UsuarioAlteracao,DataCriacao,DataAlteracao")] Colaborador colaborador)
        {
            if (ModelState.IsValid)
            {
                db.Colaborador.Add(colaborador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(colaborador);
        }

        // GET: Colaboradors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colaborador colaborador = db.Colaborador.Find(id);
            if (colaborador == null)
            {
                return HttpNotFound();
            }
            return View(colaborador);
        }

        // POST: Colaboradors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Email,Is_PCD,ForneceCarona,ResideBlumenau,Trabalho_Noturno,Data_Nascimento,Ativo,UsuarioCriacao,UsuarioAlteracao,DataCriacao,DataAlteracao")] Colaborador colaborador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(colaborador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(colaborador);
        }

        // GET: Colaboradors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colaborador colaborador = db.Colaborador.Find(id);
            if (colaborador == null)
            {
                return HttpNotFound();
            }
            return View(colaborador);
        }

        // POST: Colaboradors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Colaborador colaborador = db.Colaborador.Find(id);
            db.Colaborador.Remove(colaborador);
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
