using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    //sealed não permite herança
    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 1_407_033.655;
        }
    }

    //class SouFilho : SemFilho {
    //}

    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }

    class Pai : Avo {
        public override sealed bool HonrarNomeFamilia() {
            return true;
        }
    }

    // Sealed também não permite que seja sobreescrito
    class FilhoRebelde : Pai {
        //    public override bool HonrarNomeFamilia() {
        //        return false;
        //    }
    }

    internal class Sealed {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());
            
            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }

    }
}
