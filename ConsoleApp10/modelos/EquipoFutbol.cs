using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.modelos
{
    internal class EquipoFutbol
    {
        public string Nombre { set; get; }
        public Jugador Arquero { set; get; }        
        public List<Jugador> Jugadores { set; get; }
        
    }
}
