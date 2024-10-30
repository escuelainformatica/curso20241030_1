using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLinq.modelos
{
    internal class Factura
    {
        public int NumFactura { set; get; }
        public Cliente Cliente { set; get; }
        public List<DetalleFactura> Detalle { set; get; }

        public Factura()
        {
        }

        public Factura(int numFactura, Cliente cliente, List<DetalleFactura> detalle)
        {
            NumFactura = numFactura;
            Cliente = cliente;
            Detalle = detalle;
        }
    }
}
