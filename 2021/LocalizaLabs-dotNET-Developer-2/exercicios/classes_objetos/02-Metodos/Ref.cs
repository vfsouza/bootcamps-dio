namespace classes_objetos.Metodos {
   public class Ref {

      // Ref: indica que a variavel será recebida por referencia
      static void Inverter(ref int x, ref int y) {
         int temp = x;
         x = y;
         y = temp;
      }

      public static void Interver() {
         int x = 1, y = 2;

         Inverter(ref x, ref y);
         System.Console.WriteLine($"{x} = {y}");
      }
   }
}