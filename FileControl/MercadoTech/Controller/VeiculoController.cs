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
    public class VeiculoController : ApiController
    {
        public Context Context = Context.GetInstance();
        // GET
        public IEnumerable<Veiculo> GetVeiculos()
        {
            return Context.Veiculo.AsEnumerable();
        }

        // GET 
        public Veiculo GetVeiculo(int id)
        {
            Veiculo v = Context.Veiculo.Find(id);
            if (v == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return v;
        }

        // PUT 
        public HttpResponseMessage PutVeiculo(int id, Veiculo v)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != v.Id)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            Context.Entry(v).State = EntityState.Modified;

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
        public HttpResponseMessage PostVeiculo(Veiculo v)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Context.Veiculo.Add(v);
                    Save();

                    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, v);
                    response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = v.Id }));
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
        public HttpResponseMessage DeleteVeiculo(int id)
        {
            Veiculo v = Context.Veiculo.Find(id);
            if (v == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            Context.Veiculo.Find(id).Ativo = false;

            try
            {
                Save();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, v);
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
