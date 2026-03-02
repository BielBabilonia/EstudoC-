using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar()
        {
            var nome = "Notebook Pica to Fly";
            string marca = "Dell";
            double valor = 5800.29;

            //Duas maneiras de imprimir

            //Mais trabalhosa

            Console.WriteLine("O " + nome + " da " + marca + " custa, aproximadamente, " + valor);

            //mais rápida e elegante
            Console.WriteLine("O {0} da marca {1} custa, aproximadamente, {2}", nome, marca, valor);

            //existe uma diferente
            Console.WriteLine($"O {nome} da marca {marca} custa, aproximadamente, {valor}");

        }

    }
}
