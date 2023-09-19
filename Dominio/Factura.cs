using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistriColor.Dominio
{
    public class Factura
    {
        public int Numero { get; set; }

        public DateTime Fecha { get; set; }

        public string Cliente { get; set; }

        public FormaPago FormaPago { get; set; }

        public List<DetalleFactura> Detalles { get; set; }

        public Factura()
        {
            Detalles = new List<DetalleFactura>();
        }

        public Factura(int numero, DateTime fecha, string cliente, FormaPago formapago)
        {
            this.Numero = numero;
            this.Fecha = fecha;
            this.Cliente = cliente;
            this.FormaPago = formapago;
            Detalles = new List<DetalleFactura>();
        }

        public void AgregarDetalle(DetalleFactura detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int index)
        {
            Detalles.RemoveAt(index);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (DetalleFactura item in Detalles)
            {
                total = total + item.CalcularSubTotal();
            }
            return total;
        }

    }

}
