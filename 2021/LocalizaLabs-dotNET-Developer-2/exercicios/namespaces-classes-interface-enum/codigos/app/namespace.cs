/*
   Podemos chamar um namespace de duas formas diferentes.

   - A primeira é usando "using NOME DO NAMESPACE;"
      - Classe.printHelloPrimeiro();

   - A segunda é chamando ele com o sua classe.
      - Segundo.Classe.printHelloSegundo();
*/

using System;
using Primeiro; // Primeiro método de chamar um namespace;

namespace ExNamespace {
   class Namespace {
      public static void Principal() {
         Console.WriteLine("Podemos chamar um namespace de duas formas diferentes.\n");
         Console.WriteLine("A primeira é usando 'using NOME DO NAMESPACE;' no início do código");
         Console.WriteLine("- Classe.printHelloPrimeiro();\n");
         Console.WriteLine("A segunda é chamando ele com o sua classe");
         Console.WriteLine("- Segundo.Classe.printHelloSegundo();\n\n");
         Console.Write("Aperte ENTER para continuar...");
         Console.ReadLine();
         
         Classe.printHelloPrimeiro(); // Primeiro método chamando o namespace no using
         Segundo.Classe.printHelloSegundo(); // Segundo método chamando o namepsace inline
         Console.Write("Aperte ENTER para sair...");
         Console.ReadLine();
      }
   }
}

namespace Primeiro {
   class Classe {
      public static void printHelloPrimeiro() {
         Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\nHello Primeiro! // Print com o primeiro método\n");
      }
   }
}

namespace Segundo {
   class Classe {
      public static void printHelloSegundo() {
         Console.WriteLine("Hello Segundo! // Print com o segundo método\n");
      }
   }
}