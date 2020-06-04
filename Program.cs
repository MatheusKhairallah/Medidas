using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva um número que representará o valor de uma medida em metros:");
            double M=Convert.ToDouble(Console.ReadLine());
            double resultado1=M * 100;
            double resultado2=M / 1000;
            Console.Clear();
            Console.WriteLine($"Centímetros={resultado1}");
            Console.WriteLine("Metros=" +M);
            Console.WriteLine($"Quilometros={resultado2}");
            
        }
    }
}
