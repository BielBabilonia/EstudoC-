using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    internal class OperacoeNumericas
    {
        public static void Executar()
        {
            //Primeiro vamos calcular um valor com desconto
            var valor = 1000.0;
            var imposto = 300;
            var desconto = 0.1; // sem motivo fundado para usar VAR apenas usei

            //2 maneiras de fazer
            //1
            double precototal = valor + imposto;
            var totalcdesconto = precototal - (precototal * desconto);
            Console.WriteLine("Valor final é {0}", totalcdesconto); //sem motivo fundado pra usar essa forma de interpolação

            //ou de maneira mais direta

            double preco = (valor + imposto) - ((valor + imposto) * desconto);
            Console.WriteLine(preco);

            //usando potencias
            double peso = 65.7;
            double altura = 1.77;
            double imc = peso / Math.Pow(altura, 2); // da pra fazer so multiplicando mas assim fica mais profissional

            //agora por ultimo par e impar

            int par = 2;
            int impar = 3;

            Console.WriteLine("Se for par, o valor vai ter resto: {0} ", par % 2);//% quer saber qual o resto da divisão e não qual o resultado dela
            Console.WriteLine("Se for impar o valor vai ter resto: {0}", impar % 2);

        }
    }
}
