using System;
using System.Linq;

namespace FindTheMaxNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers separated by commas.\n");
            var input = Console.ReadLine();
            string[] numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (var item in numbers)
            {
                var number = Convert.ToInt32(item);
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine("The max number is {0}.\n", max);
        }
    }
}
