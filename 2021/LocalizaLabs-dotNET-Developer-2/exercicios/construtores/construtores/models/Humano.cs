namespace construtores.models
{
    public class Humano : Pessoa
    {
        // Usando construtores herdados
        public Humano(string nome, string sobrenome) : base(nome, sobrenome) { }
    }
}