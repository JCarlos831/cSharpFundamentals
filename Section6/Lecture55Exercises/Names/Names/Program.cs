using System;
using System.Collections.Generic;

namespace Names
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            List<string> names = new List<string>();
            var name = "";
            do
            {
                Console.WriteLine("Enter a name\n");
                name = Console.ReadLine();
                names.Add(name);
            } while (name != "");

            foreach (var i in names)
            {
                Console.Write(i);
            }
        }
    }
}
