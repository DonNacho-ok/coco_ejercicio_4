using System;
using System.Collections.Generic;

namespace ejercicio4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Sistemas de Apuestas de Ruleta Virtual... El S.A.R.V");
            Console.WriteLine("La cosa es asi, haces todas las apuestas que quieras de entre los numeros 0 y 36.");
            Console.WriteLine("Las apuestas se cierran si ingresas un valor que exceda estos limites...");

            List<int> apuestas = new List<int>();
            bool aux = true;
            while (aux)
            {
                Console.WriteLine("Ingresa tu apuesta:");
                int num = Convert.ToInt32(Console.ReadLine());

                if (0 <= num & num <= 36)
                {
                    apuestas.Add(num);
                }
                else
                {
                    aux = false;
                }
            }
            var ruleta = new Random();
            Console.WriteLine("Se cerraron las apuestas. Ahora a girar la ruleta!:");
            int winner = ruleta.Next(0, 36);

            Console.WriteLine("El ganador es el " + winner + " !!!");
            int ganadores=0, perdedores=0;
            //control de ganadores
            foreach(int apuesta in apuestas)
            {
                if (apuesta == winner)
                {
                    ganadores += 1;
                }
                else
                {
                    perdedores += 1;
                }
            }
            Console.WriteLine("Hubo " + ganadores + " apuestas ganadoras y "+perdedores+" apuestas perdedoras");
            Console.WriteLine("Gracias por apostar con nosotros, Ejecutenos Pronto \n \n");
            Console.WriteLine("La apuesta compulsiva puede ser perjudicial para la salud");

        }
    }
}
