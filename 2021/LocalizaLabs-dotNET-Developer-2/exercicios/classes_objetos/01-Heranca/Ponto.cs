namespace classes_objetos.Heranca {
   public class Ponto {
      int x, y;

      // Para variáveis internas usa-se _ antes do nome da variável
      private int _distancia;

      public Ponto(int x, int y) {
         this.x = x;
         this.y = y;
      }

      // Protected: pode ser herdado pela classe filha
      protected void CalcularDistancia() {
         // Faz algo
      }

      private void CalcularDistancia2() {
         // Faz algo
      }

      // Virtual: permite que uma classe filha o sobrescreva
      public virtual void CalcularDistancia3() {

      }
   }
}