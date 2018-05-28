using System;

namespace MaxNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number.\n");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number.\n");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var maxNumber = (number1 > number2) ? number1 : number2;
            Console.WriteLine("The maximum number between the two is {0}.\n", maxNumber);
        }
    }
}
