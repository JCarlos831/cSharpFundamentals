using System;

namespace RandomClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var random = new Random();

            const int passwordLenght = 10;

            var buffer = new char[passwordLenght];

            for (int i = 0; i < passwordLenght; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);

            Console.WriteLine(password);

        }
    }
}
