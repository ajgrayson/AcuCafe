using System;

namespace AcuCafe.Models
{
    public class HotChocolate : Drink
    {
        public override string Description
        {
            get
            {
                return "Hot Chocolate";
            }
        }

        public override string[] StandardIngredients
        {
            get
            {
                return new[] {
                    Constants.Ingredients.Milk,
                    Constants.Ingredients.Sugar,
                    Constants.Ingredients.Chocolate
                };
            }
        }
    }
}
