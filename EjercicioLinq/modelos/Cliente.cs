using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLinq.modelos
{
    internal class Cliente
    {
        public string Nombre { set; get; }
        public string Direccion { set; get; }
        public string Correo { set; get; }

        public Cliente()
        {
        }

        public Cliente(string nombre, string direccion, string correo)
        {
            Nombre = nombre;
            Direccion = direccion;
            Correo = correo;
        }
    }
}
