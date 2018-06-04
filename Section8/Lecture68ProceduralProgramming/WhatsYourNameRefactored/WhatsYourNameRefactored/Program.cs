using System;

namespace WhatsYourNameRefactored
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("Reversed name: " + reversed);
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (int i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }
            return new string(array);
        }
    }
}
