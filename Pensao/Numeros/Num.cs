using System;
using System.Collections.Generic;
using System.Text;

namespace Numeros {
    class Num {

        public int Numero { get; set; }

        public Num( int numero) {
            Numero = numero;
        }

        public override string ToString() {
            return Numero + " ";
        }
    }
}
