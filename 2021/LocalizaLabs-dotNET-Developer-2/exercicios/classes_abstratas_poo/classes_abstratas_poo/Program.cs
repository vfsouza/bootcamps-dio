using System;
using classes_abstratas_poo.models;

namespace classes_abstratas_poo {
   public class Program {
      public static void Main(string[] args) {
         Corrente c = new Corrente();

         c.Creditar(100);
         c.exibirSaldo();
      }
   }
}