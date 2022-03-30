using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog13_MrPass
{
    internal class Eventos:ISemaforo
    {
        List<Eventos> Mayor;
        Random r = new Random();
        public string NombreEv { get; set; }
        public string RestriccionesEv { get; set; }
        public DateTime FechaEv { get; set; }
        public string Lugar { get; set; }
        public int Aforo { get; set; }
        public decimal[] Precios { get; set; }

        public Eventos()
        {

        }

        public Eventos(string evento, int boletos, string clasif)
        {
            RegistraEvento(evento, boletos, clasif);
        }

        public void RegistraEvento(string ev, int bo, string cls)
        {
            List<LugarAforo> LugAforo = new List<LugarAforo>();
            LugAforo.Add(new LugarAforo() { Lugar = "Anitas 2", Aforo = 200 });
            LugAforo.Add(new LugarAforo() { Lugar = "Emporium", Aforo = 500 });
            LugAforo.Add(new LugarAforo() { Lugar = "La tremenda x", Aforo = 500 });

            DateTime date = DateTime.Now.Date;
            decimal[] price = new decimal[4] {4,1,2,3 }; 
            if (cls == "+18")
            {
                int lug;
                Console.WriteLine("Fecha del evento{0}", ev);
                if (date < DateTime.Now.Date)
                {
                    Console.WriteLine("Fecha incorrecta");
                    date = DateTime.Now.Date;
                }
                Console.WriteLine("Donde se va a llevar a cabo el evento: ");
                for (int i = 0; i < LugAforo.Count; i++)
                {
                    Console.WriteLine("{0},{1}",(i+1),LugAforo[i].Lugar);
                }
                Console.WriteLine("Registra precios del evento: ");
                for (int i = 0; i < price.Length; i++)
                {
                    Console.WriteLine("{0}");
                    price[i]= Convert.ToDecimal(Console.ReadLine());
                }

                lug = Convert.ToInt32(Console.ReadLine());
                date = Convert.ToDateTime(Console.ReadLine());
                Mayor.Add(new Eventos 
                {
                    NombreEv = ev,
                    RestriccionesEv = cls,
                    FechaEv = date,
                    Lugar = LugAforo[lug-1].Lugar,
                    Aforo = LugAforo[lug-1].Aforo,
                    Precios = price
                });
            }
        }

        public void Lugares()
        {

        }

        public double Semaforo()
        {
            double sem = r.NextDouble();
            string text;

            if (sem >= 0.0 && sem <= 0.4)
            {
                text = "ROJO";
                Console.Write("El semáforo epidemiológico esta en ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(text);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" \n El aforo permitido es del 20%");
                sem = 0.2;
            }
            else if (sem >= 0.5 && sem <= 0.8)
            {
                text = "AMARILLO";
                Console.Write("El semáforo epidemiológico esta en ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(text);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" \n El aforo permitido es del 70%");
                sem = 0.7;
            }
            else if (sem >= 0.9 && sem <= 1.0)
            {
                text = "VERDE";
                Console.Write("El semáforo epidemiológico esta en ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(text);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" \n El aforo permitido es del 100%");
                sem = 1;
            }
            return sem;
        }

    }
    
}
