using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    // Você só pode instânciar classes concretas
    // Você só tem uma classe abstrata caso tenha uma classe que herde ela
    public abstract class Celular {
        public abstract string Assistente();

        public string Tocar() {
            return "Trim trim trim...";
        }

    }

    public class Samsung : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Bixby!";    
        }
    }

    public class IPhone : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Siri";
        }
    }

    internal class Abstract {
        public static void Executar() {
            var celulares = new List<Celular> {
                new IPhone(),
                new Samsung()
            };

            foreach(var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
