using System;
using construtores.models;

namespace Construtores {
   class Program {
      public static void Main(string[] args) {
         Pessoa pessoa1 = new Pessoa();
         pessoa1.nome = "João";
         pessoa1.sobrenome = "Vitor";

         Pessoa pessoa2 = new Pessoa("Vinicius", "Ferreira");

         pessoa1.Apresentar();
         pessoa2.Apresentar();
      }
   }
}