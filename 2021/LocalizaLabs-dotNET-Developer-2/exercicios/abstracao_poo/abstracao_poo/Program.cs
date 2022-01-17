using System;
using abstracao_poo.models;

namespace abstracao_poo {
   class Program {
      public static void Main(string[] args) {
         Pessoa p1 = new Pessoa();

         p1.Nome = "Joao";
         p1.Idade = 39;

         p1.Apresentar();
      }
   }
}