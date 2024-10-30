using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.modelos
{
    internal class Pais
    {
        public string Nombre { set; get; }
        public Continente Continente { set; get; } // muchos es a uno.
        public List<Ciudad> Ciudades { set; get; } // uno es a muchos.
    }
}
