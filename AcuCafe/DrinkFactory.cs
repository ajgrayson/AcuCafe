using AcuCafe.Contracts;
using AcuCafe.Exceptions;
using AcuCafe.Models;

namespace AcuCafe
{
    public class DrinkFactory : IDrinkFactory
    {
        public Drink Create(string type)
        {
            switch(type)
            {
                case Constants.Drinks.HotChocolate:
                    return new HotChocolate();
                case Constants.Drinks.Espresso:
                    return new Espresso();
                case Constants.Drinks.Tea:
                    return new Tea();
                case Constants.Drinks.IceTea:
                    return new IceTea();
            }

            throw new UnknownDrinkTypeException();
        }
    }
}
