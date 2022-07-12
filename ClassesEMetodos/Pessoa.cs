namespace CursoCSharp.ClassesEMetodos {
    internal class Pessoa {
        public string Nome;
        public int Idade;

        public string Apresentar() {
            if (Nome.Length > 2 && Idade != 0) { 
                return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");
            } else {
                return string.Format("Por favor, preencha os dados!");
            }
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}
