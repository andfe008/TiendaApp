using api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace api.Controllers
{
    public class login : Controller
    {
        [Route(("api/[controller]"))]
        [ApiController]

        public class LoginController : Controller
        {


            [HttpPost]
            public IActionResult Validate(Models.DTOModel.DTOlogin dTOloginq)
            {

                if (dTOloginq == null)
                {

                    ModelState.AddModelError("Name", "Los datos no son validos");
                    return BadRequest(ModelState);

                }
                try
                {

                    //var login = Dataaccess.Access.Producto(x => x.Correo == dTOloginq.Correo && x.Contraseña == dTOloginq.Clave);
                    //if (login == null)
                    //{
                    //    return NotFound();
                    //}

                    return Ok();

                }
                catch (Exception)
                {
                    return StatusCode(500);
                }

            }
        }
    }
}
