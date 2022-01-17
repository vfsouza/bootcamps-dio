namespace heranca_poo.models
{
    public class Aluno : Pessoa
    {
        private int Nota;

        public Aluno() : base("", 0) {
            this.Nota = 0;
        }

        public Aluno(string Nome, int Idade, int Nota) : base(Nome, Idade) {
            this.Nota = Nota;
        }

        public void definirValores(string Nome, int Idade, int Nota) {
            this.Nota = Nota;
            base.definirValores(Nome, Idade);
        }

        public int getNota() {
            return this.Nota;
        }
    }
}