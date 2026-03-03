using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            int Palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Digite seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out Palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == Palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;

                    Console.WriteLine("Parabens, você acertou.");

                    Console.BackgroundColor = corAnterior;
                }
                else if (numeroSecreto > Palpite)
                {
                    Console.WriteLine("Número digitado é menor que o número secreto, faltam {0} tentativas", tentativasRestantes);

                }
                else if (numeroSecreto < Palpite)
                {
                    Console.WriteLine("Número digitado é maior que o número secreto, faltam {0} tentativas",tentativasRestantes);
                }
            }

        }
    }
}
