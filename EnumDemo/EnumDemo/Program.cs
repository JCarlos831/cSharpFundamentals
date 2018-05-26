using System;

namespace EnumDemo
{
    class MainClass
    {
        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }
        public static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString);

            var methodName = "Express";
            var shippingMehtod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
