using System;
using System.Collections.Generic;

#nullable disable

namespace Dataaccess.Access
{
    public partial class Producto
    {
        public Producto()
        {
            Venta = new HashSet<Ventum>();
        }

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }
        public decimal? Valor { get; set; }
        public int? Cantidad { get; set; }
        public string Imagen { get; set; }

        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
