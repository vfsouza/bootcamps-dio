namespace classes_seladas_poo.models
{
    public class Pessoa
    {
        private string Nome;
        private int Idade;

        public Pessoa(string Nome, int Idade) {
            this.Nome = Nome;
            this.Idade = Idade;
        }

        public void definirValores(string Nome, int Idade) {
            this.Nome = Nome;
            this.Idade = Idade;
        }

        // Polimorfismo Override
        public virtual void Apresentar() {
            Console.WriteLine($"{this.Nome} tem {this.Idade} anos");
        }

        public string getNome() {
            return this.Nome;
        }

        public int getIdade() {
            return this.Idade;
        }
    }
}