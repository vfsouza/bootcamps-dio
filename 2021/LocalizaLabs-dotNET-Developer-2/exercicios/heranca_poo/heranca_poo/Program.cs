using System;
using heranca_poo.models;

namespace heranca_poo {
   public class Program {
      public static void Main(string[] args) {
         Aluno a = new Aluno();
         Professor p = new Professor();

         a.definirValores("Joao", 10, 60);
         p.definirValores("Augusto", 30, 30000);

         Console.WriteLine($"{a.getNome()} tem {a.getIdade()} anos e tirou nota {a.getNota()}");
         Console.WriteLine($"{p.getNome()} tem {p.getIdade()} anos e salario igual a {p.getSalario()}");
      }
   }
}