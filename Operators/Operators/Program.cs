﻿using System;

namespace Operators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(!(c > b || c == a));
        }
    }
}
