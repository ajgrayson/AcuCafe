using System;

namespace AcuCafe.Models
{
    public class Tea : Drink
    {
        public override string[] StandardIngredients
        {
            get
            {
                return new[] {
                    Constants.Ingredients.Milk,
                    Constants.Ingredients.Sugar
                };
            }
        }

        public override string Description
        {
            get
            {
                { return "Hot tea"; }
            }
        }
    }
}
