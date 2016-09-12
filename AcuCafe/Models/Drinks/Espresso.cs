using System;

namespace AcuCafe.Models
{
    public class Espresso : Drink
    {
        public override string Description
        {
            get
            {
                return "Espresso";
            }
        }

        public override string[] StandardIngredients
        {
            get
            {
                return new[] {
                    Constants.Ingredients.Sugar,
                    Constants.Ingredients.Milk,
                    Constants.Ingredients.Chocolate
                };
            }
        }
    }
}
