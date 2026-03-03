using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.EstruturaDeControle
{
    internal class Switch
    {
        public static void Executar()
        {
            Console.WriteLine("Qual a nota você dá para nosso atendimento:");
            int.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out int nota);
            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo atendimento");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Atendimento ruim");
                    break;
                case 3:
                    Console.WriteLine("Atendimento regular");
                    break;
                case 4:
                    Console.WriteLine("Atendimento bom");
                    break;
                case 5:
                    Console.WriteLine("Atendimento ótimo");
                    break;
                default:
                    Console.WriteLine("Nota Invalida");
                    break;
            }
        }
    }
}
