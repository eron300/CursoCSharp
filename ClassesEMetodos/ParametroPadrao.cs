namespace CursoCSharp.ClassesEMetodos {
    internal class ParametroPadrao {
        // Paramêtros padrão não podem ser passado para out ou ref
        public static int Somar(int a = 1, int b = 1) {
            return a + b;
        }

        public static void Executar() {
            Console.WriteLine(Somar(10, 23));
            Console.WriteLine(Somar(50));
            Console.WriteLine();
            Console.WriteLine(Somar(b: 7));
        }
    }
}
