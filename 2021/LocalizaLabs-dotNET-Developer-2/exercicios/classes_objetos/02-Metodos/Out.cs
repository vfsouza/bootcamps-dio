namespace classes_objetos.Metodos {
   public class Out {
      // Out: serve meio que como uma return. Ele atribui um valor para as variáveis Out e as retorna
      // para as variaveis da chamada da função
      static void Dividir(int x, int y, out int resultado, out int resto) {
         resultado = x / y;
         resto = x % y;
      }

      public static void Dividir() {
         Dividir(10, 3, out int resultado, out int resto);
         System.Console.WriteLine("{0} {1}", resultado, resto);
      }
   }
}