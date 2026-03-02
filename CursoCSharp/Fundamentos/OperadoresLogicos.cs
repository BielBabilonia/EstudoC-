using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            var trabalhoter = true;
            var trabalhoquin = false;

            Console.WriteLine("Caso ambos o trabalham tenham sido feitos, haverá uma bonificação.");
            Console.WriteLine("Ambos os trabalhos foram feitos? {0}", trabalhoter && trabalhoquin);
            Console.WriteLine("Caso pelo menos um trabalho tenha sido feito, haverá um day off");
            Console.WriteLine("Um dos trabalhos foi feito? {0}", trabalhoter || trabalhoquin);
            Console.WriteLine("Caso, exclusivamente, apenas um trabalho for feito, haverá meio expediente.");
            Console.WriteLine("Exclusivamente um dos trabalhos foi feito? {0}", trabalhoter ^ trabalhoquin);
            Console.WriteLine("Caso tenha sido feito tenha sido feito um trabalho, não estamos no nosso melhor.");
            Console.WriteLine("Estamos no nosso melhor? {0}", !(trabalhoter || trabalhoquin));
        }
    }
}
