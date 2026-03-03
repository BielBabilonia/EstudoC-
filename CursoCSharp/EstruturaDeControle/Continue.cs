using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    internal class Continue
    {
        public static void Executar()
        {
            int numero = 50;

            Console.WriteLine("Números pares de 1 a {0}", numero);

            for (int i = 1; i <= numero; i++)
            {
                if(i % 2 == 1)
                {
                    continue;
                }

                Console.WriteLine(i + " ");
            }
        }
    }
}
