using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    // Lambda é uma função anônima guardada em uma variável
    internal class ExemploLambda {
        public static void Executar() {
            // Action retorna void
            // Para action só pode ser passado o parametro
            //Action algoNoConsole = () => {
            //    Console.WriteLine("Lambda com C#!");
            //};

            Action<string> algoNoConsole = (a) => {
                Console.WriteLine("Lambda com C#!" + a);
            };

            algoNoConsole("!!!");

            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            // Primeiro parametro é a entrada 'int' e o segundo o tipo do retorno 'string'
            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);

            Console.WriteLine(formatarData(1, 1, 2019));
        }
    }
}
