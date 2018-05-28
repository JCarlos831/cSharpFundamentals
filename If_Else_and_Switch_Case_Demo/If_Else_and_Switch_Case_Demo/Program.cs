using System;

namespace If_Else_and_Switch_Case_Demo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // if else if else statement
            //int hour = 10;

            //if (hour > 0 && hour < 12)
            //{
            //    Console.WriteLine("It's morning.");
            //}
            //else if (hour >= 12 && hour < 18)
            //{
            //    Console.WriteLine("It's afternoon.");
            //}
            //else
            //{
            //    Console.WriteLine("It's evening.");
            //}

            // if else statement
            // bool isGoldCustomer = true;

            // float price;
            // if (isGoldCustomer)
            //    price = 19.95f;
            // else
            //    price = 29.95f;

            // if else with conditional operator (ternary operator)
            // float price = (isGoldCustomer) ? 19.95f : 29.95f;

            // Console.WriteLine(price);

            // switch statement

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got promotion.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }
        }
    }
}
