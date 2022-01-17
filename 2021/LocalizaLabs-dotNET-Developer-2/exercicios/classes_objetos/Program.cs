using System;
using classes_objetos.Heranca;

namespace Programa {
   class Program {
      public static void Main(string[] args) {
         Ponto p1 = new Ponto(10, 20);

         Ponto3D p2 = new Ponto3D(10, 20, 30);

         // Metodo publico
         p1.CalcularDistancia3();

         // Metodo sobrescrito de Ponto
         p2.CalcularDistancia3();
      }
   }
}
