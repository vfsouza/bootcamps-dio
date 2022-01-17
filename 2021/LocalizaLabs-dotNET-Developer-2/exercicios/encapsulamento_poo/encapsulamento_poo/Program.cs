using System;
using encapsulamento_poo.models;

namespace encapsulamento_poo {
   public class Program {
      public static void Main(string[] args) {
         // Conseguimos acessar diretamente os atributos com rs.comprimento, por exemplo.
         RetanguloSemEncapsulamento rs = new RetanguloSemEncapsulamento();

         rs.comprimento = 20; rs.largura = 30;
         Console.WriteLine($"Comprimento: {rs.comprimento}\nLargura: {rs.largura}\n");

         // Não conseguimos acessar diretamente os atributo com rc.comprimento, por exemplo.
         // Para acessar suas propriedades precisamos usar seus métodos, caso a classe os tenha
         RetanguloEncapsulamento rc = new RetanguloEncapsulamento();

         rc.definirMedidas(20, 30);
         rc.printArea();
      }
   }
  
}