using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using CalculandoIDADE.Models;

namespace CalculandoIDADE.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PessoaController : ApiController
    {
        PessoaContext Context = new PessoaContext();

        public IQueryable<Pessoa> Get()
        {
            return Context.Pessoas;
        }
         
        public Pessoa Post(Pessoa data)
        {
            Context.Pessoas.Add(data);
            Context.SaveChanges();
            return data;
        }

    }
}
