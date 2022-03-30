using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog13_MrPass
{
    internal class EventosRestringidos:Eventos
    {
        public string Evento { get; set; }
        public int BoletosComprados  { get; set; }
        public string Clasificacion { get; set; }

        public EventosRestringidos(string evento, int boletos, string clasif) : base(evento, boletos, clasif)
        {
            Evento = evento;
            BoletosComprados = boletos;
            Clasificacion = clasif;
        }
    }
}
