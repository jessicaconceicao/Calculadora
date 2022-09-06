namespace Calculadora
{
    public class Operacoes
    {
        public double ValorUm { get; set; }
        public double ValorDois { get; set; }
        public Operacoes(double valorUm, double valorDois)
        {
            ValorUm = valorUm;
            ValorDois = valorDois;
        }

        public double Soma()
            { return ValorUm + ValorDois; }

        public double Subtrai()
            { return ValorUm - ValorDois; }

        public double Multiplica()
            { return ValorUm * ValorDois; }

        public double Divide()
            { return ValorUm / ValorDois; }

    }
}
