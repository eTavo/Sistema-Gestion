using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entidades
{
    public class eArticulos
    {
        public string Articulo { get; set; }
        public string Proveedor { get; set; }
        public float precioVenta { get; set; }
        public float precioCompra { get; set; }
        public int Cantidad { get; set; }
    }
}
