using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumeros
    {
        public static void Executar()
        {
            double Variavel = 15.98;

            Console.WriteLine(Variavel.ToString("F3")); // Aqui diz que quero 3 casa decimais
            Console.WriteLine(Variavel.ToString("C")); // Aqui fala que quero na forma de Dinheiro
            Console.WriteLine(Variavel.ToString("P")); // Aqui diz que quero em porcentagem
            Console.WriteLine(Variavel.ToString("#.#")); //Aqui só diz que quero 1 casa decimal de uma forma diferente

            //Mas e se eu quiser colocar em outra moeda? e não a do sistema

            CultureInfo ValorEUA = new CultureInfo("en-US");
            Console.WriteLine(Variavel.ToString("C", ValorEUA));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D5"));



        }
    }
}
