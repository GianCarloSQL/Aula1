using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MercadoTech.Model;

namespace WebAPI.Controllers
{
    public class CorsController : Controller
    {
        private Context db = new Context();

        // GET: Cors
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View(await db.Cor.ToListAsync());
        }

        // GET: Cors/Details/5
        [Route("api/cors")]
        [HttpGet]
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cor cor = await db.Cor.FindAsync(id);
            if (cor == null)
            {
                return HttpNotFound();
            }
            return View(cor);
        }

        // GET: Cors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Codigo,Nome,Ativo,UsuarioCriacao,UsuarioAlteracao,DataCriacao,DataAlteracao")] Cor cor)
        {
            if (ModelState.IsValid)
            {
                db.Cor.Add(cor);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cor);
        }

        // GET: Cors/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cor cor = await db.Cor.FindAsync(id);
            if (cor == null)
            {
                return HttpNotFound();
            }
            return View(cor);
        }

        // POST: Cors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Codigo,Nome,Ativo,UsuarioCriacao,UsuarioAlteracao,DataCriacao,DataAlteracao")] Cor cor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cor).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cor);
        }

        // GET: Cors/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cor cor = await db.Cor.FindAsync(id);
            if (cor == null)
            {
                return HttpNotFound();
            }
            return View(cor);
        }

        // POST: Cors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Cor cor = await db.Cor.FindAsync(id);
            db.Cor.Remove(cor);
            await db.SaveChangesAsync();
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
