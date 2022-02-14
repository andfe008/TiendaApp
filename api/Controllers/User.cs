using ApiUsuario.Models.Renponse;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers
{ 

     [Route(("api/[controller]"))]
     [ApiController]
    public class User : Controller
    {
        Respuesta<List<Dataaccess.Access.Usuario>> oRespuesta = new Respuesta<List<Dataaccess.Access.Usuario>>();

        [HttpGet]
        public IActionResult Get()
        {
            using (Dataaccess.Access.TiendaContext db = new Dataaccess.Access.TiendaContext())
            {
                var lis = (from x in db.Usuarios select x).ToList();
                oRespuesta.Exito = 1;
                oRespuesta.Data = lis;

                return Ok(oRespuesta);

            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id) {

            Respuesta<Dataaccess.Access.Usuario> oRespuesta = new Respuesta<Dataaccess.Access.Usuario>();

            using (Dataaccess.Access.TiendaContext db = new Dataaccess.Access.TiendaContext())
            {
                var lis = db.Usuarios.Find(id);
                oRespuesta.Exito = 1;
                oRespuesta.Data = lis;
                return Ok(oRespuesta);
            }
        }


        [HttpPost]
        public IActionResult Post([FromBody] Dataaccess.Access.Usuario model)
        {
            Respuesta<object> oRespuesta = new Respuesta<object>();
            try
            {
                using (Dataaccess.Access.TiendaContext db = new Dataaccess.Access.TiendaContext())
                {

                    Dataaccess.Access.Usuario user = new Dataaccess.Access.Usuario();
                    user.Nombre = model.Nombre;
                    user.Apellido = model.Apellido;
                    user.Telefono = model.Telefono;
                    user.Correo = model.Correo;
                    user.Rol = model.Rol;
                    user.Contraseña = model.Contraseña;          
                    db.Usuarios.Add(user);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }

            }
            catch (Exception)
            {
                return StatusCode(500);
            }


            return Ok(oRespuesta);

        }




        [HttpPost("{id}")]
        public IActionResult Post(int id,[FromBody] Dataaccess.Access.Usuario model)
        {
            Respuesta<object> oRespuesta = new Respuesta<object>();
            try
            {
                using (Dataaccess.Access.TiendaContext db = new Dataaccess.Access.TiendaContext())
                {

                    Dataaccess.Access.Usuario idit = db.Usuarios.Find(model.IdUsuario);
                    idit.Nombre = model.Nombre;
                    idit.Apellido = model.Apellido;
                    idit.Telefono = model.Telefono;
                    idit.Correo = model.Correo;
                    idit.Rol = model.Rol;
                    idit.Contraseña = model.Contraseña;
                    db.Usuarios.Add(idit);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }

            }
            catch (Exception)
            {
                return StatusCode(500);
            }


            return Ok(oRespuesta);

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            try
            {
                using (Dataaccess.Access.TiendaContext db = new Dataaccess.Access.TiendaContext())
                {
                    Dataaccess.Access.Usuario delete = db.Usuarios.Find(id);
                    db.Usuarios.Remove(delete);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;

            }
            return Ok(oRespuesta);
        }

    }
}
