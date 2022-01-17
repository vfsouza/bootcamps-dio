namespace heranca_poo.models
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

        public string getNome() {
            return this.Nome;
        }

        public int getIdade() {
            return this.Idade;
        }
    }
}