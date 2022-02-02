using System;
using delegates.models;

namespace delegates {
   class Program {
      public delegate void operacao(int x, int y);
      public static void Main(string[] args) {
         operacao op = Calculadora.Somar;

         System.Console.Write("Soma 10 + 10 = ");
         op.Invoke(10, 10);

         op = Calculadora.Subtrair;

         System.Console.Write("Subtração 10 - 5 = ");
         op(10, 5);

         // Multicast Delegates
         op = Calculadora.Somar;
         op += Calculadora.Subtrair;
         System.Console.WriteLine("Multicast: (10, 5)");
         op(10, 5);
      }
   }
}