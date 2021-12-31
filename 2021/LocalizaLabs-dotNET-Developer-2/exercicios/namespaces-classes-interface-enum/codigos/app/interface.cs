using System;

namespace ExInterface {
   interface IInterface { // Interface que define a classe Interface
      void Principal(string s);
   }
   class Interface : IInterface {
      public string Principal { get; set; }	
      void IInterface.Principal(string s) { // Método que define o valor do atributo Principal definido pela interface IInterface
         this.Principal = s;
      }

      public void printHelloS() { // Print de um 'Hello {string}', no qual, string, é definido pelo input da pessoa
         Console.WriteLine("\nHello {0} // Print com atributo de classe criado a partir de uma interface\n", this.Principal);
         Console.Write("Aperte ENTER para continuar...");
         Console.ReadLine();
      }
   }

   
}