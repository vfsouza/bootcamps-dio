using System;
using System.Collections.Generic;

namespace colecoes.models {
    public class Lista {
        public static void PrintList(List<string> list) {
            System.Console.WriteLine("\nQuantidade de elementos: {0}", list.Count);
            for (int i = 0; i < list.Count; i++) {
                System.Console.WriteLine("{0}. {1}", i + 1, list[i]);
            }
        }

        public static void TestList() {
            List<string> nomes = new List<string>();
            string[] nomes2 = new string[3] {"Joao", "Dudu", "Caio"};
            
            nomes.Add("Vinicius");
            nomes.Add("Paula");
            nomes.Add("Pedro");

            PrintList(nomes);

            nomes.Remove("Pedro");
            System.Console.WriteLine("\nPedro foi removido da lista.");
            PrintList(nomes);

            nomes.AddRange(nomes2);
            PrintList(nomes);

            nomes.Insert(1, "Agnostolfo");
            nomes.Insert(4, "Alan");

            PrintList(nomes);
        }
    }
}