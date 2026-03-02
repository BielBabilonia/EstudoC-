using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 9;
            var bomcomportamento = true;

            var resultado = nota >= 6 && bomcomportamento == true ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
