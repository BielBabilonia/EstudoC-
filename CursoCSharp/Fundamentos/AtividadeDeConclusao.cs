using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class AtividadeDeConclusao
    {
        public static void Executar()
        {

            //Criando a váriavel sem atribuição
            string NomeCliente;
            double valorcompra;
            int itensadicionados;
            double imposto;
            //Fazendo a leitura dos inputs
            Console.WriteLine("Digite o nome do cliente: ");
            NomeCliente = Console.ReadLine();
            Console.WriteLine("Qual o valor da compra do cliente: ");
            valorcompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//Aqui há o Parse para transformar String em Double, e tambem o forçamento do uso do "." como separador de casas decimais
            Console.WriteLine("Quantos itens do mesmo foram adicionados ao carrinho: ");
            itensadicionados = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto de imposto há sobre o produto: ");
            imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Aqui há o Parse para transformar String em Double, e tambem o forçamento do uso do "." como separador de casas decimais

            //Calculo do valor total com taxas
            double valorstaxa = valorcompra * itensadicionados;
            double valortotal = valorstaxa + imposto;

            //Verificação se há desconto
            bool cartão = false;
            bool voucher = true;
            var desconto = cartão == true && voucher == true ? "Aprovado" : "Reprovado"; //Aqui há o uso do operador Ternário para entendimento do status de aprovação do desconto, seguindo a função lógica "E", onde ambos devem ser True

            CultureInfo ValorEUA = new CultureInfo("en-US"); // Criando a currency de dollar, se quisesse criar outra so utilizar ("language-COUNTRY")

            Console.WriteLine($"Olá, senhor(a) {NomeCliente}, sua compra foi no total de {valorstaxa.ToString("C", ValorEUA)}, após aplicação do imposto o total foi de: {valortotal.ToString("C", ValorEUA)}"); //Uso da formatação monetaria usando a currency criada
            Console.WriteLine("Obrigado por comprar conosco, volte sempre {0}", NomeCliente);

            /*correções que o chatgpt fez para deixar codigo mais limpo:
             * 
                 *Ternário
                     * var desconto = cartão == true && voucher == true ? "Aprovado" : "Reprovado"; 
                     * viraria
                     * var desconto = cartão && voucher ? "Aprovado" : "Reprovado";
                     * Em C#, você não precisa comparar boolean com true
                 *Variaveis
                     * Utilização do camelCase nas variaveis 
                     * ex: NomeCliente > nomeCliente, valorcompra > valorCompra, itensadicionados > itensAdicionados
                     */
                  
            

        }
    }
}
