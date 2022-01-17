namespace heranca_poo.models
{
    public class Professor : Pessoa
    {
        private int Salario;

        public Professor() : base("", 0) {
            this.Salario = 0;
        }

        public Professor(string Nome, int Idade, int Salario) : base(Nome, Idade) {
            this.Salario = Salario;
        }

        public void definirValores(string Nome, int Idade, int Salario) {
            this.Salario = Salario;
            base.definirValores(Nome, Idade);
        }

        public int getSalario() {
            return this.Salario;
        }
    }
}