using EjercicioLinq.modelos;
using EjercicioLinq.servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fact = new Factura
            {
                NumFactura = 29,
                Cliente = new Cliente
                {
                    Nombre = "Quillet S.A.",
                    Direccion = "Autovia",
                    Correo = "info@quillet.com"
                },
                Detalle = new List<DetalleFactura>
                {
                    new DetalleFactura
                    {
                        Producto="Casco Bluebird",
                        Cantidad=2,
                        PrecioUnitario=28
                    },
                    new DetalleFactura
                    {
                        Producto="Mailot Elite Rojo",
                        Cantidad=1,
                        PrecioUnitario=49
                    },
                    new DetalleFactura
                    {
                        Producto="Faro delanterio",
                        Cantidad=3,
                        PrecioUnitario=9
                    },
                }
            };
            var fact2 = new Factura(29
                , new Cliente("Quillet S.A.", "Autovia", "info@quillet.com")
                , new List<DetalleFactura>
                    {
                        new DetalleFactura("Casco Bluebird",2,28),
                        new DetalleFactura("Mailot Elite Rojo",1,49),
                        new DetalleFactura("Faro delanterio",3,9),
                    });

            var facturas = new List<Factura>
            {
                new Factura(27
                , new Cliente("Quillet S.A.", "Autovia", "info@quillet.com")
                , new List<DetalleFactura>
                    {
                        new DetalleFactura("Casco Bluebird",2,28),
                        new DetalleFactura("Mailot Elite Rojo",1,49),
                        new DetalleFactura("Faro delanterio",3,9),
                    }),
                new Factura(28
                , new Cliente("Quillet S.A.", "Autovia", "info@quillet.com")
                , new List<DetalleFactura>
                    {
                        new DetalleFactura("Casco Bluebird",2,28),
                        new DetalleFactura("Mailot Elite Rojo",1,49),
                        new DetalleFactura("Faro delanterio",3,9),
                    }),
                new Factura(29
                , new Cliente("Otra compañia", "Autovia", "info@quillet.com")
                , new List<DetalleFactura>
                    {
                        new DetalleFactura("Casco Bluebird",2,28),
                        new DetalleFactura("Mailot Elite Rojo",1,49),
                        new DetalleFactura("Faro delanterio",3,9),
                    })
            };
            Console.WriteLine("---- listado facturas Quillet:");
            var facturasfiltradas = FacturaSrv.Filtro(facturas);
            FacturaSrv.MostrarListado(facturasfiltradas);
            Console.WriteLine("---- ");

            FacturaSrv.Mostrar(fact);
            var cantidad = FacturaSrv.SumaCantidad(fact);
            var total = FacturaSrv.Total(fact);
            Console.WriteLine($"Cantidad: {cantidad}, total: {total}");

        }
    }
}
