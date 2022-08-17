using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite um número: ");
            string input = Console.ReadLine();
            int number;
            bool result = Int32.TryParse(input, out number);
            while (!result)
            {
                Console.WriteLine("\nNúmero inválido \n");
                Console.WriteLine("Digite um número: ");
                input = Console.ReadLine();
                result = Int32.TryParse(input, out number);
                   
            }
            int sum = 0;
            string sumString = "";
            for(int i = 0; i <= number; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                    if(i == number)
                    {
                        sumString += i;
                    } else
                    {
                        sumString += i + " + ";
                    }
                }
            }
            Console.WriteLine("\nSoma dos multiplos de 3 ou 5 de 0 à " + number +": " + sumString + " = " + sum);
            
            
        }
        
    }
}