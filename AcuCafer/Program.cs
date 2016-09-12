using System;
using System.Linq;

namespace AcuCafer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Missing drink type");
            }

            var type = args[0].Trim();

            var hasMilk = false;
            var hasSugar = false;
            var hasChocolate = false;

            if (args.Length > 1)
            {
                hasMilk = args.Skip(1).Any(c => c.ToLowerInvariant() == "milk");
                hasSugar = args.Skip(1).Any(c => c.ToLowerInvariant() == "sugar");
                hasChocolate = args.Skip(1).Any(c => c.ToLowerInvariant() == "chocolate");
            }

            var cafe = new AcuCafe.AcuCafe(
                new AcuCafe.Logger(), 
                new AcuCafe.Waiter(),
                new AcuCafe.DrinkFactory(),
                new AcuCafe.Barista()
            );

            cafe.OrderDrink(type, hasMilk, hasSugar, hasChocolate);

            Console.ReadKey();
        }
    }
}
