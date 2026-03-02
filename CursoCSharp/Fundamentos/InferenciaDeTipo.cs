using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class InferenciaDeTipo
    {
        public static void Executar()
        {
            var nome = "Gabriel"; //C# reconhece que existe aspas duplas e converte nome para string, não podendo ser convertido posteriormente de novo
            Console.WriteLine(nome);

            int idade; //aqui eu declarei a variavel
            idade = 22; // Aqui eu inicializei ela dando um valor inicial
            Console.WriteLine(idade);

            int idade2 = 23; //Aqui eu declarei e inicializei
            Console.WriteLine(idade2);

        }
    }
}
