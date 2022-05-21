using System;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Введите целое число: ");
            int unknownNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("___________________START___________________");
            bool isSimple = true;
            int i = 1;
            while (i < unknownNumber)
            {                 
                int remainder = unknownNumber % i;                
                if (i != 1 && remainder == 0)
                {
                    isSimple = false;                 
                }
                i++;            
            }
            string result = isSimple ? "Число простое" : "Число не простое";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
