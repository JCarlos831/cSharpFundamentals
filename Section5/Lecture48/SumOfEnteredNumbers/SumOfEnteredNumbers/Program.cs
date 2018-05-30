using System;

namespace SumOfEnteredNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var sumNums = 0;

            while (true)
            {
                Console.WriteLine("Enter a number or type \"ok\" to exit.");

                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                {
                    break;
                }
                else
                {
                    sumNums += Convert.ToInt32(input);
                }

                Console.WriteLine(sumNums);
            }
        }
    }
}
