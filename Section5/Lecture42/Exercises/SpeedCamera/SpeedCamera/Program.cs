using System;

namespace SpeedCamera
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var demeritPoints = 0;
            Console.WriteLine("Enter Speed Limit.\n");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the car's speed in km/hr.\n");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok\n");
            }
            else if (carSpeed > speedLimit)
            {
                demeritPoints = (carSpeed - speedLimit) / 5;
                Console.WriteLine("You have accumulated {0} demerit points.\n", demeritPoints);
            }

            if (demeritPoints > 12)
            {
                Console.WriteLine("License Suspended\n");
            }
        }
    }
}