using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ExAngularJs.Models;
using System.Web.Script.Serialization;
using System.Net.Http.Formatting;
using ExAngularJs.Context;

namespace ExAngularJs.Controllers
{
    public class UsuarioController : ApiController
    {
        private readonly Usuario[] Usuarios = new Usuario[]
        {
            new Usuario {Nome = "Alex"},
            new Usuario {Nome = "Anderson"},
            new Usuario {Nome = "Juliana"},
            new Usuario {Nome = "Teixeira"},
            new Usuario {Nome = "Jarbas"},
        };


        private string Usuario(FormDataCollection form)
        {
            string nome = form.Get("Nome");
            string email = form.Get("Email");
            string telefone = form.Get("Telefone");

            Usuario obj = new Usuario()
            {
                Nome = nome,
                Email = email,
                Telefone = telefone
            };

            return "Customer added successfully!";

        }

        
        // GET api/usuario
        public String Get()
        {
            JavaScriptSerializer s = new JavaScriptSerializer();


            return s.Serialize(Usuarios);
            
           //return Usuarios;

        }

        // GET api/usuario/5
        public Usuario Get(string Nome)
        {

            var usuarios = Usuarios;

            return usuarios.SingleOrDefault(z => z.Nome == Nome);
        }

        // POST api/usuario
        [HttpPost]
        public IHttpActionResult Post(Usuario model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            using (TesteContext db = new TesteContext())
            {
                db.Usuario.Add(model);
                db.SaveChanges();             

            }
            


            return Ok(model);
        }

        // PUT api/usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/usuario/5
        public void Delete(int id)
        {
        }
    }
}
