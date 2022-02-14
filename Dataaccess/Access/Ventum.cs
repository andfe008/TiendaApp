using System;
using System.Collections.Generic;

#nullable disable

namespace Dataaccess.Access
{
    public partial class Ventum
    {
        public int IdVenta { get; set; }
        public decimal? Valor { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdProducto { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuario IdUsuario1 { get; set; }
        public virtual Producto IdUsuarioNavigation { get; set; }
    }
}
