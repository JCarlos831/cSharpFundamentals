using System;
using System.IO;

namespace Lecture73DirectoryAndDirectoryInfoDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Directory.CreateDirectory(@"/Users/JuanCMontoya/Projects/Udemy/csharp/c_sharp_basics_w_mosh/folder1");

            var files = Directory.GetFiles(@"/Users/JuanCMontoya/Projects/Udemy/csharp/c_sharp_basics_w_mosh/Section8", "*.sln*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"/Users/JuanCMontoya/Projects/Udemy/csharp/c_sharp_basics_w_mosh/Section8", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
