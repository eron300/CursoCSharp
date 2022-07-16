﻿using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;

namespace CursoCSharp {
    // Namespace -> As classes teram nomes únicos dentro de um mesmo 'espaço'
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                
                // Fundamentos

                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo dados - Fundamentos", LendoDados.Executar },
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar },

                // Estruturas de controle

                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar },
                {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },              
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar },              
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar },
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar },
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar },

                // Classes e Metódos

                {"Membros - Classes e Metódos", Membros.Executar },
                {"Construtores - Classes e Metódos", Construtores.Executar },
                {"Métodos Com Retorno - Classes e Metódos", MetodosComRetorno.Executar },
                {"Métodos Estáticos - Classes e Metódos", MetodosEstaticos.Executar },
                {"Atributos Estáticos - Classes e Metódos", AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes e Metódos", DesafioAtributo.Executar },
                {"Params - Classes e Metódos", Params.Executar }, 
                {"Parametros Nomeados - Classes e Metódos", ParametrosNomeados.Executar },
                {"Get Set - Classes e Metódos", GetSet.Executar },
                {"Props - Classes e Metódos", Props.Executar },
                {"Readonly - Classes e Metódos", Readonly.Executar },
                {"Enum - Classes e Metódos", ExemploEnum.Executar },
                {"Struct - Classes e Metódos", ExemploStruct.Executar },
                {"Struct Vs Classe - Classes e Metódos", StructVsClasse.Executar },
                {"Valor Vs Referência - Classes e Metódos", ValorVSReferencia.Executar },
                {"Parâmetros Por Referência - Classes e Metódos", ParametrosPorReferencia.Executar },
                {"Parâmetro com Valor Padrão - Classes e Metódos", ParametroPadrao.Executar },

                // Coleções

                {"Array - Coleções", Colecoes.Array.Executar },
                {"List - Coleções", ColecoesList.Executar },
                {"Array List - Coleções", ColecoesArrayList.Executar },
                {"Set - Coleções", ColecoesSet.Executar },
                {"Queue - Coleções", ColecoesQueue.Executar },
                {"Igualdade - Coleções", Igualdade.Executar },
                {"Stack - Coleções", ColecoesStack.Executar },
                {"Dictionary - Coleções", ColecoesDictionary.Executar },

                //OO

                {"Herança - OO", Heranca.Executar },
                {"Construtor This - OO", ConstrutorThis.Executar },
                {"Encapsulamento This - OO", OO.Encapsulamento.Executar },
                {"Polimorfismo - OO", Polimorfismo.Executar },
                {"Abstract - OO", Abstract.Executar },
                {"Interface - OO", Interface.Executar },
                {"Sealed - OO", Sealed.Executar },

            });

            central.SelecionarEExecutar();
        }
    }
}