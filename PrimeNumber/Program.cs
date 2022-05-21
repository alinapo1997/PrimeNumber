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
            int i = 2;
            int end = (int)Math.Ceiling((Math.Sqrt(unknownNumber)));              
            while (i < end)
            {
                Console.WriteLine(i);                              
                if (unknownNumber % i == 0)
                {
                    isSimple = false;                    
                    break;
                }
                i++;            
            }
            string result = isSimple ? "Число простое" : "Число не простое";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
