using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ParametrosPorReferencia {
        public static void AlterarRef(ref int numero) {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero1, out int numero2) {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 15;
        }

        public static void Executar() {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            // int b;
            // O out é unidirecional / saída / Não altera o valor inicial
            // O out é útil como uma forma de uma função "retornar" mais de um valor,
            // já que existem casos onde vamos querer obter mais de um valor a partir de uma função

            int b = 3;
            Console.WriteLine(b);
            AlterarOut(out b, out int c);
            Console.WriteLine($"{b} {c}");
        }
    }
}
