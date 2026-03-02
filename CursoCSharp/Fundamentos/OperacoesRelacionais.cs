using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class OperacoesRelacionais
    {
        public static void Executar()
        {
            double nota = 6.0;
            double notacorte = 6.5;

            Console.WriteLine("Nota é: {0} Nota de corte é: {1}", nota, notacorte);
            Console.WriteLine("Sua nota é maior que a média? {0}", nota > notacorte);
            Console.WriteLine("Sua nota é perfeita? {0}", nota == 10);
            Console.WriteLine("Sua nota é 0? {0}", nota == 0);
            Console.WriteLine("Sua nota pode ser melhorada? {0}", nota != 10); // nesse quesito c# lembra muito o python, não houve dificuldade nenhuma nesse módulo

            //Utilizando input
            Console.WriteLine("Qual foi sua nova nota?");
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double notanova);
            double notacortenova = 6.0;
            Console.WriteLine("Nota é: {0} Nota de corte é: {1}", notanova, notacortenova);
            Console.WriteLine("Sua nota é maior que a média? {0}", notanova > notacortenova);
            Console.WriteLine("Sua nota é perfeita? {0}", notanova == 10);
            Console.WriteLine("Sua nota é 0? {0}", notanova == 0);
            Console.WriteLine("Sua nota pode ser melhorada? {0}", notanova != 10);

        }

    }
}
