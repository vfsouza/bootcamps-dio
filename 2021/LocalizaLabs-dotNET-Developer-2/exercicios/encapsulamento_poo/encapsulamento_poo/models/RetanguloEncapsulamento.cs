using System;

namespace encapsulamento_poo.models
{
    public class RetanguloEncapsulamento
    {
        private double comprimento;
        private double largura;

        // Encapsulamento: usamos métodos para mudar os atributos
        public void definirMedidas(double comprimento, double largura) {
            this.comprimento = comprimento;
            this.largura = largura;
        }

        public void printArea() {
            Console.WriteLine($"Area: {comprimento * largura}");
        }
    }
}