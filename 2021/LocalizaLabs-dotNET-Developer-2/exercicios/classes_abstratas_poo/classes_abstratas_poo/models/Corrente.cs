namespace classes_abstratas_poo.models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            this.Saldo += valor;
        }
    }
}