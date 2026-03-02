using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamento
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", Variaveis_Constantes.Executar},
                {"Inferência de Tipos - Fundamentos", InferenciaDeTipo.Executar},
                {"Interpolação de strings - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotaçãoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões - Fundamentos", Conversao.Executar},
                {"Operações númericas - Fundamentos", OperacoeNumericas.Executar},
                {"Operações Relacionais - Fundamentos", OperacoesRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadorAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                {"Atividade de Conclusão de módulo - Fundamentos", AtividadeDeConclusao.Executar},
                //Estruturas de Controle
                {"Estrutura de Controle IF - Estruturas de Controle", EstruturaIF.Executar},
            });

            central.SelecionarEExecutar();
        }
    }

}