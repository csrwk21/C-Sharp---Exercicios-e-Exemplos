using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1 {
    class ConversorDeMoeda {
        public static double Iof = 6.0;
        
        public static double ConverterMoeda(double quantidade, double cotacao ) {
            double total = cotacao * quantidade;
            return total + total * Iof / 100;
        }
    }
}
