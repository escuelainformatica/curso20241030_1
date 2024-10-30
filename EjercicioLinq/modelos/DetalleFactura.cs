using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLinq.modelos
{
    internal class DetalleFactura
    {
        public string Producto { set; get; }
        public int Cantidad { set; get; }
        public int PrecioUnitario { set; get; }

        public DetalleFactura(string producto, int cantidad, int precioUnitario)
        {
            Producto = producto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
        }

        public DetalleFactura()
        {
        }
    }
}
