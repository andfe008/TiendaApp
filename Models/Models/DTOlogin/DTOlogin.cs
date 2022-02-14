using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models.DTOModel
{
    public class DTOlogin
    {
        public string Correo { get; set; }
        public string Clave { get; set; }
    }
}
