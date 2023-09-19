using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistriColor.Dominio
{
    public class Articulo
    {
        public int Codigo { get; set; }

        public string Descripcion { get; set; }

        public double Precio { get; set; }

        public Articulo()
        {
            Codigo = 0;
            Descripcion = string.Empty;
            Precio = 0;
        }

        public Articulo(int codigo, string descripcion, double precio)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Precio = precio;
        }

        public override string ToString()
        {
            return "| Código Art: " + Codigo + " | Descripción: " + Descripcion + " | Precio: " + Precio;
        }
    }
}
