// Realizando operações matemáticas básicas entre dois valores 
using Calculadora;

Console.WriteLine("Qual operação gostaria de realizar? Digite 1[soma] 2[subtração] 3[multiplicação] 4[divisão]");
string operacao = Console.ReadLine();
if (int.TryParse(operacao, out int operacaoInt) == false || operacaoInt <1 || operacaoInt > 4)
{

    Console.WriteLine("Selecione uma opção válida");
}
else
{
    Console.WriteLine("Digite o primeiro valor");
    string entradaUm = Console.ReadLine();

    if (double.TryParse(entradaUm, out double valorUm) == false)
    {
        Console.WriteLine("Digite um número válido");
    }
    else
    {
        Console.WriteLine("Digite o segundo valor");
        string entradaDois = Console.ReadLine();

        if (double.TryParse(entradaDois, out double valorDois) == false)
        {
            Console.WriteLine("Digite um número válido");
        }
        else
        {
            var valores = new Operacoes(valorUm, valorDois);

            switch (operacaoInt)
            {
                case 1:
                    Console.WriteLine($" ({valorUm}) + ({valorDois}) = {valores.Soma().ToString("F")}");
                    break;
                case 2:
                    Console.WriteLine($" ({valorUm}) - ({valorDois}) = {valores.Subtrai().ToString("F")}");
                    break;
                case 3:
                    var resultadoMultiplicacao = valores.Multiplica();
                    var verificaMultiplicacao = new IsNaN();
                    Console.WriteLine($" ({valorUm}) * ({valorDois}) = {verificaMultiplicacao.VerifyNaN(resultadoMultiplicacao)}");
                    break;
                case 4:
                    if (valorDois == 0)
                    {
                        Console.WriteLine($" ({valorUm}) / ({valorDois}) = Resultado inexistente");
                    }
                    else
                    {
                        var resultadoDivisao = valores.Divide();
                        var verificaDivisao = new IsNaN();
                        Console.WriteLine($" ({valorUm}) / ({valorDois}) = {verificaDivisao.VerifyNaN(resultadoDivisao)}");
                    }
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida)");
                    break;
            }
        }
    }
}