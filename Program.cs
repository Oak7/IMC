using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o peso em Kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe sua altura em metros");
            double altura = double.Parse(Console.ReadLine());

            double IMC = peso /(altura* altura);
        }
    }
}
