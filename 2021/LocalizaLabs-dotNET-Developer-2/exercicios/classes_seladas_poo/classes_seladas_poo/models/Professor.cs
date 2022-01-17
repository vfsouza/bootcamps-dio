namespace classes_seladas_poo.models
{
    // Selamento da classe Professor. Ela não pode ser herdade por nenhuma outra classe
    public sealed class Professor : Pessoa
    {
        private int Salario;

        // Overload - INICIO
        // Duas assinaturas iguais, mas com parâmetors diferentes
        public Professor() : base("", 0) {
            this.Salario = 0;
        }

        public Professor(string Nome, int Idade, int Salario) : base(Nome, Idade) {
            this.Salario = Salario;
        }
        // Overload - FIM

        public void definirValores(string Nome, int Idade, int Salario) {
            this.Salario = Salario;
            base.definirValores(Nome, Idade);
        }

        public int getSalario() {
            return this.Salario;
        }
    }
}