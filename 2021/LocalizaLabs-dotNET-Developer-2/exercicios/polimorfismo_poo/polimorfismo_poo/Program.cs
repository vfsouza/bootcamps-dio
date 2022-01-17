using System;
using polimorfismo_poo.models;

namespace polimorfismo_poo {
   public class Program {
      public static void Main(string[] args) {
         Aluno a = new Aluno();
         Professor p = new Professor();
         Professor p2 = new Professor("Roberto", 52, 5000);

         a.definirValores("Joao", 10, 60);
         p.definirValores("Augusto", 30, 30000);

         a.Apresentar();
         Console.WriteLine($"{p.getNome()} tem {p.getIdade()} anos e salario igual a {p.getSalario()}");
         Console.WriteLine($"{p2.getNome()} tem {p2.getIdade()} anos e salario igual a {p2.getSalario()}");
      }
   }
}