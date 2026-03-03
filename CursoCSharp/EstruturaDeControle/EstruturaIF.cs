using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIF
    {
        public static void Executar()
        {
            bool bomcomportamento = false;
            string entrada;
            Console.WriteLine("Quanto foi a nota do aluno");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("O aluno teve bom comportamento?[Y/N]");
            entrada = Console.ReadLine();
            bomcomportamento = entrada.ToLower() == "y";// se o valor for esse a variavel bom comportamento já fica true, sem precisar fazer ifs e troca-la manualmente

            if (nota >= 8 && bomcomportamento)
                Console.WriteLine("Aluno na lista de honra do colégio!");

        }
    }
}
