using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleApp1 {
    class Calculator {

        public static double Iof = 6.0;

        public static double Coverter(double quantia, double cotacao) {
            double total = quantia * cotacao;
            return total + total * Iof / 100;
        }
    }
}
