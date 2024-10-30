using EjercicioLinq.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLinq.servicios
{
    internal class FacturaSrv
    {
        public static void Mostrar(Factura fact)
        {
            Console.WriteLine($"Nº {fact.NumFactura}");
            Console.WriteLine($"Cliente {fact.Cliente.Nombre} {fact.Cliente.Direccion} {fact.Cliente.Correo}");
            //Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;            
            fact.Detalle.ForEach(d => Console.WriteLine($"{d.Producto} {d.Cantidad} {d.PrecioUnitario}"));
            Console.ResetColor();
            
        }
        public static int SumaCantidad(Factura fact)
        {
            var resultado = 0;
            resultado = fact.Detalle.Sum(d => d.Cantidad);
            return resultado;
        }
        public static int Total(Factura fact)
        {
            var resultado = 0;
            resultado = fact.Detalle.Sum(d => d.Cantidad*d.PrecioUnitario);
            return resultado;
        }
        public static List<Factura> Filtro(List<Factura> facturas)
        {
            var resultados = new List<Factura>();
            resultados = facturas.Where(fact => fact.Cliente.Nombre == "Quillet S.A.").ToList();
            return resultados;
        }
        public static void MostrarListado(List<Factura> facturas)
        {
            facturas.ForEach(fact => Mostrar(fact));
        }
    }
}
