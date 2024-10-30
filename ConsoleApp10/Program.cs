using ConsoleApp10.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var equipo = new EquipoFutbol
            {
                Nombre = "Seleccion Chilena",
                Arquero = new Jugador
                {
                    Nombre = "Lawrence Vigouroux",
                    Edad = 22,
                    Numero = 1
                },
                Jugadores = new List<Jugador>
                {
                    new Jugador {Nombre="Matías Zaldivia",},
                    new Jugador {Nombre="Marcelo Morales",},
                }
                
            };

            Console.WriteLine(equipo.Nombre);
            Console.WriteLine(equipo.Arquero.Nombre);

            // pais, ciudad y continente
            var ciudad = new Ciudad
            {
                Nombre = "Arica",
                Pais = new Pais
                {
                    Nombre = "Chile",
                    Continente = new Continente
                    {
                        Nombre = "America",
                    }
                }
            };
            Console.WriteLine(ciudad.Pais.Continente.Nombre);
            var continente = new Continente
            {
                Nombre="America",
                paises=new List<Pais>
                {
                    new Pais
                    {
                        Nombre="Chile",
                        Ciudades=new List<Ciudad>
                        {
                            new Ciudad
                            {
                                Nombre="Arica"
                            },
                            new Ciudad
                            {
                                Nombre="Iquque"
                            }
                        }
                        
                    }
                }
            };

        }
    }
}
