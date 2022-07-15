using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class Cliente {
        public string Nome;
        // readonly deve ser usado quando deseja setar um valor no momento da construção do objeto
        public readonly DateTime Nascimento;
        
        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;

            Nascimento = new DateTime(2020, 10, 10);
        }

        public string GetDataDeNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }

    internal class Readonly {
        // Static -> não preciso criar um objeto para função ser executada
        // O tipo de retorno sempre estara ao lado do nome da função
        public static void Executar() {
            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

            // novoCliente.Nascimento = new DateTime(2020, 10, 10);
        }
    }
}
