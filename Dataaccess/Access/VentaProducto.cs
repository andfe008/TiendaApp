using System;
using System.Collections.Generic;

#nullable disable

namespace Dataaccess.Access
{
    public partial class VentaProducto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }
        public decimal? Valor { get; set; }
        public string Expr1 { get; set; }
        public int? Cantidad { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
