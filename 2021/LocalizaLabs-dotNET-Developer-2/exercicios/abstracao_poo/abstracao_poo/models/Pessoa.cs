using System;

namespace abstracao_poo.models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar() {
            Console.WriteLine($"Ola, meu nome é {this.Nome} e tenho {this.Idade} anos");
        }
    }
}