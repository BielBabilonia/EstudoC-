using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIfElseIf
    {
        public static void Executar()
        {
            string entrada;
            Console.WriteLine("Qual a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, CultureInfo.InvariantCulture, out double nota);

            if (nota >= 8)
            {
                Console.WriteLine("Aluno aprovado com honraria");
            }
            else if (nota >= 6)
            {
                Console.WriteLine("Passou de raspão...");
            }
            else
            {
                Console.WriteLine("Nos vemos na proxima...");
            }

            Console.WriteLine("Fim do programa!");
        }
    }
}
