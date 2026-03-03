using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization; 

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIfElse
    {
        public static void Executar()
        {
            string entrada;

            Console.WriteLine("Qual a nota do aluno:");
            entrada = Console.ReadLine();
            double.TryParse(entrada,CultureInfo.InvariantCulture, out double nota);

            if (nota >= 6)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine("Aluno reprovado!");
            }

        }

    }
}
