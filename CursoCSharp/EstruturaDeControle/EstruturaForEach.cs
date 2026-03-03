using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "é o brasil!";

            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var turma = new string[] { "Bia", "Bruno", "Carlos" };

            foreach(var nome in turma)
            {
                Console.WriteLine(nome); 
            }
        }
    }
}
