using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {

    internal class Igualdade {
        public static void Executar() {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            Console.WriteLine(p1 == p2); // False - Compara refência de memória
            Console.WriteLine(p2 == p3);

            Console.WriteLine(p1.Equals(p2)); // Por default também compara o endereço de memória, porém utilizando o Equals ele compara com o valor
        }
    }
}
