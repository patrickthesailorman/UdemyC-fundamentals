using System;

namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID);

            Console.WriteLine(method.ToString()); // Console.Writeline automatically applies ToString() to whatever its passed.

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName); // convert Parse string to enum string
        }
    }
}
