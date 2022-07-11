using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // Uma casa decimal
            Console.WriteLine(valor.ToString("C")); // Moeda local
            Console.WriteLine(valor.ToString("P")); // Multiplica por 100 e coloca em %
            Console.WriteLine(valor.ToString("#.##")); // Coloca no formato exemplificado

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("CO", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // Acrescenta a quantidade de zeros a esquerda que for colocado
        }
    }
}
