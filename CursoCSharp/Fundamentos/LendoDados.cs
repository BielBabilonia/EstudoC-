using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual o seu nome fi de deus?");
            string Nome = Console.ReadLine();

            Console.Write("Quantos anos você tem?");
            // int Idade = Console.ReadLine(); aqui daria erro por não conseguir converter de String para int
            int Idade = int.Parse(Console.ReadLine()); //Aqui eu uso o parse para converter de forma segura para int

            Console.Write("Qual a pretensão Salarial?");
            double Salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"O {Nome} que tem {Idade} tem a pretensão salarial de {Salario}.");


            //Porem aqui temos um problema, ele vai ler , ou . baseado no sistema, e o usuario teria que saber o que colocar
            //Para ele negar isso e sempre levar em conta a separação sistematica . basta adicionar o system.Globalization e usar
            //CultureInfo.InvariantCulture, isso deixa de levar em conta qual o sistema usa e sempre vai levar em conta o . como separador

            Console.Write("Qual o seu nome fi de deus?");
            string Nome2 = Console.ReadLine();

            Console.Write("Quantos anos você tem?");
            int Idade2 = int.Parse(Console.ReadLine()); 

            Console.Write("Qual a pretensão Salarial?");
            double Salario2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"O {Nome2} que tem {Idade2} tem a pretensão salarial de {Salario2}.");
        }
    }
}
