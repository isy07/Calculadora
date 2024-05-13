using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos;

public class Calculadora
{ 
    public static double Somar(double n1, double n2)
    {
        return n1 + n2;
    }

    public static double Subtrair(double n1, double n2)
    {
        return n1 - n2;
    }
    public static double Multiplicar(double n1, double n2)
    {
        return n1 * n2;
    }

    public static double Dividir(double n1, double n2)
    {
        if (n2 != 0)
        {
            return n1 / n2;
        }
        else
        {
            Console.WriteLine("Operação invalida");
            return 0;
        }
    }

    public static double Potencia (double n1, double n2)
    {
        return Math.Pow (n1, n2);
    }

    public static double RaizQuadrada (double n1)
    {
        return Math.Sqrt (n1);
    }

    


}

    


