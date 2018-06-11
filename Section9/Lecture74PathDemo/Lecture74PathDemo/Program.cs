using System;
using System.IO;

namespace Lecture74PathDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var path = @"/Users/JuanCMontoya/Projects/Udemy/csharp/c_sharp_basics_w_mosh/HelloWorld/HelloWorld.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}
