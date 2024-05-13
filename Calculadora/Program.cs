
using Calculos;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Digite o símbolo correspondente a operação que deseja realizar:");

        var simbolo = Console.ReadLine();
        double resultado = 0;
        if (simbolo == "r")
        {
            Console.WriteLine("Digite o número que deseja saber a raiz quadrada:");
            var n1 = double.Parse(Console.ReadLine());
             resultado = Calculadora.RaizQuadrada(n1);
            Console.WriteLine(resultado);

        }
        else
        {
            Console.WriteLine("Digite o primeiro número");
            var n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            var n2 = double.Parse(Console.ReadLine());


            switch (simbolo)
            {
                case "+":
                    resultado = Calculadora.Somar(n1, n2);
                    break;

                case "-":
                    resultado = Calculadora.Subtrair(n1, n2);
                    break;

                case "*":
                    resultado = Calculadora.Multiplicar(n1, n2);
                    break;

                case "/":
                    resultado = Calculadora.Dividir(n1, n2);
                    break;

                case "**":
                    resultado = Calculadora.Potencia(n1, n2);
                    break;

            }

        }
        Console.WriteLine($"O resultado é {resultado}");


    }

}