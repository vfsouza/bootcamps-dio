using System;
using get_set.models;

namespace get_set {
   class Program {
      public static void Main(string[] args) {
         Data data = new Data();
         
         try {
            data.setMes(13);
         } catch (ArgumentException e) {
            System.Console.WriteLine(e);
         }

         System.Console.WriteLine(data.getMes());
      }
   }
}