using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    internal class OperadorAtribuicao
    {
        public static void Executar()
        {
            var num1 = 1;
            num1 = 7; //aqui eu estou trocando, num1 = 1 passa a ser num1 = 7

            num1 += 1; //aqui eu estou adicionando, num1 = 7 + 1
            num1 -= 1; // Aqui eu estou diminuindo, num1 = 7 - 1
            num1 *= 2; //aqui estou multiplicando, num1 = 7*2
            num1 /= 7; //aqui estou dividindo, num1 = 14/2

            Console.WriteLine(num1);

            var a = 1;
            var b = a; //aqui estou copiando o valor de a para b

            a++; // aqui estou adicionando 1 unidade a = a + 1
            b--; //aqui estou diminuindo 1 unidade b = a - 1

            Console.WriteLine($"{a}, {b}");

        }
    }
}
