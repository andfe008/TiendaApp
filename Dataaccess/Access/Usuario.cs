using System;
using System.Collections.Generic;

#nullable disable

namespace Dataaccess.Access
{
    public partial class Usuario
    {
        public Usuario()
        {
            Venta = new HashSet<Ventum>();
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public bool? Rol { get; set; }
        public bool? Estado { get; set; }
        public string Contraseña { get; set; }

        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
