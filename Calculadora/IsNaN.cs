namespace Calculadora
{
    public class IsNaN
    {
        public double valor;

        public string VerifyNaN(double valor)
        {
            if (valor != valor)
            { return "Número não existe"; }
            else
            { return valor.ToString("F"); }
        }
    }
}