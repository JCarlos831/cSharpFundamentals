using System;

namespace ValidNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 10.\n");
            var number = Convert.ToInt32(Console.ReadLine());

            var isValid = (number >= 1 && number <= 10) ? "Valid" : "Invalid";
            Console.WriteLine(isValid);
        }
    }
}
