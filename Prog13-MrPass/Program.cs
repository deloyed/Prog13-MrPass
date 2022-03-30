using System;

namespace Prog13_MrPass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* EventosGral ev1=new EventosGral();
             ev1.Semaforo();
             Console.WriteLine(ev1); */
            int sel;
            do {
                Console.WriteLine("Bienvenido al sistema de gestión" +
                "de eventos Mr.Pass... inicie sesion.");
                CtrlAcceso acceso =  new CtrlAcceso();
                sel = acceso.Validate();
                switch (sel)
                {
                    case 0:
                        Console.WriteLine("No te acuerdas de tu clave? Arre pues");
                        acceso.Validate();
                        break;
                    case 1:
                        Console.WriteLine("Que tipo de Evento quieres registrar?"+
                            "\n1. Evento General\n2. Evento Restringido");
                        sel = Convert.ToInt32(Console.ReadLine());
                        if (sel == 1)
                        {
                            EventosGral ev = new EventosGral();
                        }
                        else { 
                            EventosRestringidos eve=new EventosRestringidos();
                        }
                        break;
                    case 2:
                        Console.WriteLine("La lista de eventos disponibles es: ");
                        BoletoCliente cliente = new BoletoCliente();
                        break;
                }
            } while (sel!=5);
          





        }
    }
}
