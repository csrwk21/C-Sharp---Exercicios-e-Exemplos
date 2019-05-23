using System;
using System.Globalization;

namespace TrianguloExercicio {
    class Program {
        static void Main(string[] args) {

            Triangulo triangulo = new Triangulo();

            triangulo.lerValoresX(); // método para ler os valores dos lados do Triangulo A
            triangulo.lerValoresY(); // método para ler os valores dos lados do Triangulo B

            triangulo.calcularArea(); // Cálcula a área do triangulo X e Y
      

            triangulo.testarArea(); // Testa se o triângulo X ou Y é maior 

            Console.ReadLine(); // comando para não fechar a tela  ao executar o programa no console.
        }
    }
}

