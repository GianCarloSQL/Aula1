using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using MercadoTech.Model;

namespace MercadoTech.Controller
{
    public class CorController : ApiController
    {
        public Context Context = Context.GetInstance();
        // GET
        public IEnumerable<Cor> GetCor()
        {
            return Context.Cor.AsEnumerable();
        }

        // GET 
        public Cor GetCor(int id)
        {
            Cor c = Context.Cor.Find(id);
            if (c == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return c;
        }

        // PUT 
        public HttpResponseMessage PutCor(Cor c)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            Context.Entry(c).State = EntityState.Modified;

            try
            {
                Save();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST 
        public HttpResponseMessage PostCor(Cor c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Context.Cor.Add(c);
                    Save();

                    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, c);
                    response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = c.Id }));
                    return response;
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE
        public HttpResponseMessage DeleteCor(int id)
        {
            Cor c = Context.Cor.Find(id);
            if (c == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            Context.Cor.Find(id).Ativo = false;

            try
            {
                Save();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, c);
        }

        protected override void Dispose(bool disposing)
        {
            Context.Dispose();
            base.Dispose(disposing);
        }

        private void Save()
        {
            Context.SaveChanges();
        }
    }

}
