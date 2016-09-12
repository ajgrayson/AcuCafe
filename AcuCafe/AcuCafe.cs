using AcuCafe.Contracts;
using AcuCafe.Exceptions;
using AcuCafe.Models.Ingredients;

namespace AcuCafe
{
    public class AcuCafe
    {
        protected readonly IWaiter _waiter;
        protected readonly ILogger _logger;
        protected readonly IDrinkFactory _drinkFactory;
        protected readonly IBarista _barista;

        public AcuCafe(ILogger logger, IWaiter waiter, IDrinkFactory drinkFactory, IBarista barista)
        {
            _waiter = waiter;
            _logger = logger;
            _drinkFactory = drinkFactory;
            _barista = barista;
        }

        public Drink OrderDrink(string type, bool hasMilk, bool hasSugar, bool hasChocolate)
        {
            var drink = _drinkFactory.Create(type);

            try
            {
                if (hasMilk)
                {
                    drink.AddIngredient(new Milk());
                }

                if (hasSugar)
                {
                    drink.AddIngredient(new Sugar());
                }

                if(hasChocolate)
                {
                    drink.AddIngredient(new Chocolate());
                }

                _waiter.Serve(_barista.Prepare(drink));
            }
            catch (InvalidIngredientException ex)
            {
                _waiter.Serve(ex.Message);
                _logger.LogException(ex);
            }

            return drink;
        }
    }
}