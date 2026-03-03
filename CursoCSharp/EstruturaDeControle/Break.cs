using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    internal class Break
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine("{0} é o número?", i);

                if (i == numero)
                {
                    Console.WriteLine("Sim!");
                    break;
                }
                else
                {
                    Console.WriteLine("Não");
                }
            }
        }
    }
}
