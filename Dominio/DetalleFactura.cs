using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistriColor.Dominio
{
    public class DetalleFactura
    {
        Articulo Articulo { get; set; }

        public int Cantidad { get; set; }

        public DetalleFactura(Articulo articulo, int cantidad)
        {
            Articulo = articulo;
            Cantidad = cantidad;
        }

        public double CalcularSubTotal()
        {
            return Articulo.Precio * Cantidad;
        }
    }
}
