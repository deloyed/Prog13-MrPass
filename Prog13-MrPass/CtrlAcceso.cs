using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog13_MrPass
{
    internal class CtrlAcceso
    {
        string[,] users;
        public CtrlAcceso()
        {
            users = new string[4, 2] { { "Escamilla Prod", "12Yehaa" },
                { "Telon de Arena", "Perla4ever" }, { "CaballeroDesnochado", "YlasBuchonas1" }, 
                { "RosaCeleste", "MiexMeMantiene" } };
        }
        public int Validate()
        {
            string user;
            string pass;
            int count = 1;
            int ans;
            Console.WriteLine("Por favor introduzca su Usuario...");
            user= Console.ReadLine();
            Console.WriteLine("Por favor introduzca su password");
            pass= Console.ReadLine();

            if (user != null || pass != null)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (user == users[i, 0])
                    {
                        if (pass == users[i, 1])
                        {
                            Console.WriteLine("Bienvenido {0}, que deseas realizar hoy"+
                                "...", users[i,0]);
                            if (i <= 1)
                            {
                                ans = 1;
                                return ans;
                            }
                            else
                            {
                                ans = 2;
                                return ans;
                            }

                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Usuario o Passwor incorrecto... Intente otra vez");
                count++;
                if (count == 3)
                {
                    Console.WriteLine("Debes esperar 96 hrs para volver a equivocarte");
                    count = 0;
                    Validate();

                }
                else
                {
                    Validate();

                }
            }
            ans = 0;
            Console.Clear();
            return ans;
        }
    }
}
