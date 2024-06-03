using System;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num1 = 0;
            double Num2 = 0;
            double Num3 = 0;

            Console.WriteLine("Ingrese el primer número: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número: ");
            Num3 = Convert.ToInt32(Console.ReadLine());
            double resultado = (Num1 + Num2 + Num3) / 3;
            Console.WriteLine(resultado);
        }
    }
}