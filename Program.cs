using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quilômetros e centímetros tem dentro de 150 metros?");
            double M=150;
            double resultado1=M * 100;
            double resultado2=M / 1000;
            Console.Write("Centímetros=");
            Console.WriteLine($"{resultado1}");
            Console.WriteLine("Metros=150");
            Console.Write("Quilometros=");
            Console.WriteLine($"{resultado2}");
            
        }
    }
}
