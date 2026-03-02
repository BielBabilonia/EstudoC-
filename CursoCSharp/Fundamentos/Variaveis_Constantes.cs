using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Variaveis_Constantes
    {
        public static void Executar()
        {
            //Calcular a area de um circulo
            double Raio = 4.5; //Pode ser alterado ao longo do código
            const double PI = 3.14; //Não pode ser alterado ao longo do código

            double Area = PI * (Raio * Raio);
            Console.WriteLine("A área é " + Area); // sempre usar " " pois '' dá erro na quantidade de caracter, tambem não entendi .-.

            //Outros tipos para Variaveis

            byte Idade = 45;

            Console.WriteLine("A idade é " + Idade);

            byte ValorMaximo = byte.MaxValue;
            Console.WriteLine(ValorMaximo);//Valor maximo do byte

            bool Chuva = true;
            Console.WriteLine("Está chovendo: " + Chuva);

            short salario = short.MaxValue;
            Console.WriteLine("O maior sálario é de: " + salario);

            int numero = int.MaxValue;
            Console.WriteLine("O maior número que consigo escrever é: " + numero); // Esse daqui é o mais usado. 

            sbyte negativos = sbyte.MinValue;
            Console.WriteLine("O menor número que o sbyte chega é: " + negativos);

            //byte por natureza não tem sinal diferente do int. Se quiser sinal do byte é sbyte e se quiser tirar o sinal do int uint

            long maiorint = long.MaxValue;
            Console.WriteLine("Maior valor int com sinal é: " + maiorint);// quando colocamos um valor muito grande podemos usar _ para separar as casas tipo: 7_000_321

            ulong maioruint = ulong.MaxValue;
            Console.WriteLine("Maior valor int sem sinal é: " + maioruint);

            //Decimais

            float preco = 1200.23f; // Quando fazemos uma váriavel tipo Float temos que colocar o f no final, pois sem o f ele vira double. E a maior diferença é que o Double tem o dobro de armazenamento do float
            Console.WriteLine("Preço é: " + preco);

            decimal maiordecimal = decimal.MaxValue;
            Console.WriteLine("Maior decimal existente na linguagem: " + maiordecimal);

            //letras

            char vogal = 'a'; //Por isso deu erro antes '' é para letras únicas e "" cadeias de letras
            Console.WriteLine("A primeira vogal é: " + vogal);

            string frase = "Cadeia de caracteres";
            Console.WriteLine("Quando usamos aspas duplas? " + frase); 

        }
    }
}
