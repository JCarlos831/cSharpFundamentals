using System;

namespace ImageOrientation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of your image.\n");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height of your image.\n");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = (width > height) ? "Your image is in landscape orientation.\n" : "Your image is in portrait orientation.\n";
            Console.WriteLine(orientation);
        }
    }
}
