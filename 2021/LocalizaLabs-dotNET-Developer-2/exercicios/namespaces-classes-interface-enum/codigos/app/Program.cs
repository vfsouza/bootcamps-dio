using System;
using ExNamespace;
using ExClasse;
using ExInterface;
using ExEnum;

namespace Program {
   class Program {
      public static void Main(string[] args) {

         Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n");
         Console.WriteLine("1 - Namespace\n2 - Classe\n3 - Interface\n4 - Enum\n");
         Console.Write("Qual das opções acima vc deseja testar? ");
         int op = int.Parse(Console.ReadLine());
         Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n");
         
         switch (op) {
            case 1: 
               Namespace.Principal();
               break;
            case 2: 
               Classe cl = new Classe();
               cl.Principal();
               break;
            case 3:
               Interface interf = new Interface();
               Console.Write("Digite seu nome: ");
               string s = Console.ReadLine().ToString();
               interf.Principal = s;
               interf.printHelloS();
               break;
            case 4: 
               Console.WriteLine("Nomes printados a partir de um Enum\n");
               for (int i = 0; i < 5; i++) { 
                  string nome = ((Pessoas)i).ToString();
                  Console.WriteLine("{0}", nome);
               }
               Console.Write("\nAperte ENTER para sair...");
               Console.ReadLine();
               break;
            default: 
               Console.WriteLine("Opção inválida!\n\nEncerrando o programa...");
               break;
         }
      }
   }
}