using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistriColor.Dominio
{
    public class FormaPago
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public FormaPago()
        {
            Codigo = 0;
            Descripcion = string.Empty;
        }

        public FormaPago(int codigo, string descripcion)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
