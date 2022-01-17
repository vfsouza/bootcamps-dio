namespace classes_objetos.Heranca {
   public class Ponto3D : Ponto {
      int z;

      public Ponto3D(int x, int y, int z) : base(x, y) {
         this.z = z;
         CalcularDistancia();
      }

      // Declaracao de membro estatico (não é necessário instanciar esse objeto para utiliza-lo)
      public static void Calcular() {
         // Faz algo
      }

      // Override: sobrescreve o método com Virtual
      public override void CalcularDistancia3() {
         // Faz algo
      }
   }
}