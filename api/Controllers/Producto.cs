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

    public class Producto : Controller
    {
        

        Respuesta<List<Dataaccess.Access.Producto>> oRespuesta = new Respuesta<List<Dataaccess.Access.Producto>>();

        [HttpGet]
        public IActionResult Get()
        {
            using (Dataaccess.Access.TiendaContext db = new Dataaccess.Access.TiendaContext())
            {
                var lis = (from x in db.Productos select x).ToList();
                oRespuesta.Exito = 1;
                oRespuesta.Data = lis;

                return Ok(oRespuesta);

            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            Respuesta<Dataaccess.Access.Producto> oRespuesta = new Respuesta<Dataaccess.Access.Producto>();

            using (Dataaccess.Access.TiendaContext db = new Dataaccess.Access.TiendaContext())
            {
                var lis = db.Productos.Find(id);
                oRespuesta.Exito = 1;
                oRespuesta.Data = lis;
                return Ok(oRespuesta);
            }
        }


        [HttpPost]
        public IActionResult Post([FromBody] Dataaccess.Access.Producto model)
        {
            Respuesta<object> oRespuesta = new Respuesta<object>();
            try
            {
                using (Dataaccess.Access.TiendaContext db = new Dataaccess.Access.TiendaContext())
                {

                    Dataaccess.Access.Producto Produc = new Dataaccess.Access.Producto();
                    Produc.Nombre = model.Nombre;
                    Produc.Descripción = model.Descripción;
                    Produc.Cantidad = model.Cantidad;
                    Produc.Imagen = model.Imagen;
                    db.Productos.Add(Produc);
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
        public IActionResult Post(int id, [FromBody] Dataaccess.Access.Producto model)
        {
            Respuesta<object> oRespuesta = new Respuesta<object>();
            try
            {
                using (Dataaccess.Access.TiendaContext db = new Dataaccess.Access.TiendaContext())
                {

                    Dataaccess.Access.Producto Produc = db.Productos.Find(model.IdProducto);
                    Produc.Nombre = model.Nombre;
                    Produc.Descripción = model.Descripción;
                    Produc.Cantidad = model.Cantidad;
                    Produc.Imagen = model.Imagen;
                    db.Productos.Add(Produc);
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
                    Dataaccess.Access.Producto delete = db.Productos.Find(id);
                    db.Productos.Remove(delete);
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
