using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.modelos
{
    internal class Ciudad
    {
        public string Nombre { set; get; }
        public Pais Pais { set; get; } // muchos es a uno.
    }
}
