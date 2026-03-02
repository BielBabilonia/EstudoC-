using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotaçãoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá ".ToUpper().Insert(3, "Mundo").Replace("Mundo", "World");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            //Conceito do nulo

            string Valorimportante = null; // estou dizendo que ValorImportante está vazio, ao usar notação ponto com valores vazios dá erro
            // Console.WriteLine(Valorimportante.ToUpper);
            Console.WriteLine(Valorimportante?.ToUpper()); //Ao fazer assim fazemos navegação segura e ele so passa se o valor nao for vazio,se for ele retorna tambem um valor vazio
        }
    }
}
