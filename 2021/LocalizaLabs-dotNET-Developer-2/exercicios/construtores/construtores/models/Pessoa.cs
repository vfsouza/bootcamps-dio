namespace construtores.models {
   public class Pessoa {
      public string nome;
      public string sobrenome;

      // Construtor padrão
      public Pessoa() {
         nome = string.Empty;
         sobrenome = string.Empty;
      }

      // Construtor específico
      public Pessoa(string nome, string sobrenome) {
         this.nome = nome;
         this.sobrenome = sobrenome;
      }

      public void Apresentar() {
         System.Console.WriteLine($"Meu nome é {nome} {sobrenome}");
      }
   }
}