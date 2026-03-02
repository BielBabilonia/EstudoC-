using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    internal class Conversao
    {
        public static void Executar()
        {
            //int para double é simples
            int lula = 22;
            double bolsonaro = lula; // Aqui é uma conversão implicita, pois não a perda de info e o C# converte por si só
            Console.WriteLine(lula); 

            //double para int se perde as casas decimais nesse metodo e fica apenas o inteiro
            double nota = 9.7;
            int notaTruncada = (int)nota; //É preciso colocar assim pois voce está dizendo que assume os riscos de perca de informações
            Console.WriteLine(notaTruncada);

            Console.WriteLine("Qual a sua idade");
            string idadeString = Console.ReadLine();
            //Conversão com parse, que já vi
            int idade = int.Parse(idadeString);
            Console.WriteLine(idade);
            //conversão com int32
            idade = Convert.ToInt32(idadeString);
            Console.WriteLine(idade);

            //tryparse

            Console.WriteLine("Digita ai oh: ");
            string Palavra = Console.ReadLine();
            int Numero;
            int.TryParse(Palavra, out Numero); //Aqui ele tenta fazer o parse para INT, caso o usuario tenha posto letras e nao numeros o que é impossivel de ir pra int ele retorna 0
            Console.WriteLine(Numero);

            //há uma maneira mais direta de fazer isso em poucas linhas que é

            Console.WriteLine("Digita de novo:");
            int.TryParse(Console.ReadLine(), out int Numero2);
            Console.WriteLine(Numero2);



        }
    }
}
