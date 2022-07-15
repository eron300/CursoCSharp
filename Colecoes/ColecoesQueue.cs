using System.Collections;


namespace CursoCSharp.Colecoes {
    internal class ColecoesQueue {
        public static void Executar() {
            var fila = new Queue<string>();

            // Adiciona a fila
            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());
            // Count == Lenght 
            Console.WriteLine(fila.Count);

            // Remove da fila
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach(var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
