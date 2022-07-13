using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class CalculadoraEstatica {
        // Static significa que não pertence mais ao objeto e sim a classe, e possui apenas uma única cópia que é compartilhada com todos os objetos
        // Para utilizar um metodo sem static é necessário fazer uma instância

        // Método de Classe ou Método estático!!!
        public static int Multiplicar(int a, int b) {
            return a * b;
        }

        // Método de instância!!!
        public int Somar(int a, int b) {
            return a + b;
        }
    }

    internal class MetodosEstaticos {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));
        }
    }
}
