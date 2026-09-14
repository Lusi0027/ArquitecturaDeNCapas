using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }
        public int IdCategoria { get; set; }
    }
}
