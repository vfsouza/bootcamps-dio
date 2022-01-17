namespace classes_abstratas_poo.models
{
    public abstract class Conta
    {
        protected double Saldo;

        public abstract void Creditar(double valor);

        public void exibirSaldo() {
            Console.WriteLine($"Seu saldo é: {this.Saldo}");
        }
    }
}