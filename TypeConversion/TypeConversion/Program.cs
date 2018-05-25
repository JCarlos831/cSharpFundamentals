using System;

namespace TypeConversion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(str);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

        }
    }
}