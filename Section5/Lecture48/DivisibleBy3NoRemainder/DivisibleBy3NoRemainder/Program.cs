using System;

// Write a program to count how many numbers between 1 and 100 are divisible by
// 3 with no remainder. Display the count on the console.

namespace DivisibleBy3NoRemainder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var divisible = 0;
                
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    divisible++;
            }

            Console.WriteLine("There are {0} numbers divisible by 3 with no remainder between 1 and 100.", divisible);
        }
    }
}
