using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, m = 0, count = 0;
            Console.Write("Enter the Number : ");
            num = int.Parse(Console.ReadLine());
            m = num / 2;
            for (i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    Console.Write("The " +num+ " is not a Prime Number.");
                    count = 1;
                    break;
                }
            }
            if (count == 0)
                Console.Write("The " +num + " is a Prime Number.");

        }
    }
}
