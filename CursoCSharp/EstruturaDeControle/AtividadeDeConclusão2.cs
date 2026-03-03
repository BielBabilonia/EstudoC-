using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.EstruturaDeControle
{
    internal class AtividadeDeConclusão2
    {
        public static void Executar()
        {
            /*menu (while + switch
             * 1 - Adicionar produto
             * 2 - Ver total
             * 3 - Finalizar compra
             * 4 - Sair
             * 
             * Adicionar produto:
             * Perguntar nome [x]
             * Perguntar preço [x]
             * Perguntar quantidade [x]
             * Calcular subtotal [x]
             * Somar no total geral [x]
             * 
             * Ver total:
             * Total parcial [x]
             * Quantidade de produtos adicionados [x]
             * 
             * Finalizar compra:
             * Se total > 500 → 15% desconto [x]
             * Se total > 200 → 10% desconto [x]
             * Senão → sem desconto [x]
             * Valor bruto [x]
             * Valor desconto [x]
             * Valor final [x]
             */

            //Sessão de declaração de variaveis externas do DoWhile
            int entrada;
            double totalParcial = 0;
            int quantidadeProdutos = 0;
            //Menu de seleção
            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Adicionar produto");
                Console.WriteLine("2 - Ver total");
                Console.WriteLine("3 - Finalizar compra");
                Console.WriteLine("4 - Sair");

                int.TryParse(Console.ReadLine(), out entrada); //Transfomando em int para comparação no while, e memorizar TryParse

                switch (entrada)
                {
                    case 1:
                        Console.WriteLine("Qual o nome do produto: ");
                        var nome = Console.ReadLine();
                        Console.WriteLine("Qual o valor do produto adicionado: ");
                        double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double valor);
                        Console.WriteLine("Quantos produtos do mesmo foram adicionados: ");
                        int.TryParse(Console.ReadLine(), out int produtosIguais);
                        quantidadeProdutos += produtosIguais; //somando a quantidade de produtos que foram adicionados a quantidade que já existe no carrinho
                        double totalAtual = valor * produtosIguais;
                        totalParcial += totalAtual; // fazendo o mesmo para o total parcial, para depois ser aplicado desconto
                        Console.WriteLine("O total dessa adição de: {0}", totalAtual.ToString("C"));
                        break;
                    case 2:
                        Console.WriteLine("O total atual de sua compra é de: ");
                        Console.WriteLine(totalParcial.ToString("C"));
                        Console.WriteLine("Você tem um total de {0} item(s) adicionado ao carrinho.", quantidadeProdutos);
                        break;
                    case 3:
                        Console.WriteLine("Vamos finalizar sua compra.");
                        if (totalParcial >= 500)
                        {
                            double valorDescontado = totalParcial - (totalParcial * 0.15);
                            Console.WriteLine("Parabéns, você ganhou 15% de desconto nessa compra!");
                            Console.WriteLine("O seu total era de {0}, após o desconto ficou de {1}.", totalParcial, valorDescontado);
                        }
                        else if (totalParcial >= 200)
                        {
                            double valorDescontado = totalParcial - (totalParcial * 0.10);
                            Console.WriteLine("Parabéns, você ganhou 10% de desconto nessa compra!");
                            Console.WriteLine("O seu total era de {0}, após o desconto ficou de {1}.", totalParcial, valorDescontado);
                        }
                        else
                        {
                            Console.WriteLine("Não foi dessa vez...Você não atingiu o limite min. de compra para ganhar o desconto.");
                            Console.WriteLine("O total de sua compra foi {0}",totalParcial);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Saindo do programa. Obrigado por usar!");
                        break;
                    default:
                        Console.WriteLine("Número invalido");
                        break;
                }
            }
            while (entrada != 4);



        }
    }
}
