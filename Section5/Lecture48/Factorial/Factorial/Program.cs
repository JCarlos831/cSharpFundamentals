using System;

namespace Factorial
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var factorial = 1;
            Console.WriteLine("Please enter a number.");
            var initialNumber = Convert.ToInt32(Console.ReadLine());
            var number = initialNumber;

            while (number > 1)
            {
                factorial *= number ;
                number--;
            }

            Console.WriteLine("{0}! = {1}", initialNumber, factorial);
        }
    }
}
