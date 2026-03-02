using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            var valornegativo = -3;
            var n1 = 2;
            var n2 = 3;
            var booleano = true;

            Console.WriteLine(-valornegativo);//troca o sinal
            Console.WriteLine(!booleano); //inverte para o oposto, true <> false ou false <> true
            Console.WriteLine(++n1);//incrementa +1
            Console.WriteLine(--n1);//decrementa -1

        }
    }
}
