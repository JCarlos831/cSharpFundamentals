using System;

//Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
//etc and focus purely on the logic.Write a program that asks the user to enter the speed limit. Once set, the 
//program asks for the speed of a car.If the user enters a value less than the speed limit, program should display
//Ok on the console.If the value is above the speed limit, the program should calculate the number of demerit points.
//For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the 
//number of demerit points is above 12, the program should display License Suspended.

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