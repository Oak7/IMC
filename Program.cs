using System;


namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o peso em Kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double IMC = peso /(altura*altura);

            if(IMC < 20)
            {
                Console.WriteLine("\nIMC = {0:00} ---> abaixo do peso" , IMC);
            }
            else if((IMC >= 20) && (IMC <=24))
            {
                Console.WriteLine("IMC = {0:00} ---> normal" , IMC);
            }
            else if((IMC >= 25) && (IMC <=29))
            {
                Console.WriteLine("IMC = {0:00} ---> acima do peso" , IMC);
            }
            else if((IMC >= 30) && (IMC <=34))
            {
                Console.WriteLine("IMC = {0:00} ---> obeso",IMC);
            }
            else
            {
                Console.WriteLine("IMC = {0:00} ---> muito obeso",IMC);

            }
        }
    }
}
