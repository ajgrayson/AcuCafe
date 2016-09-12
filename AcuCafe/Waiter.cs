using System;
using AcuCafe.Contracts;

namespace AcuCafe
{
    public class Waiter : IWaiter
    {
        public void Serve(string drinkDescription)
        {
            Console.WriteLine(drinkDescription);
        }
    }
}
