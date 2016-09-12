using System;

namespace AcuCafe.Models
{
    public class IceTea : Drink
    {
        public override string[] StandardIngredients
        {
            get
            {
                return new[] {
                    Constants.Ingredients.Sugar
                };
            }
        }

        public override string Description
        {
            get
            {
                { return "Ice tea"; }
            }
        }
    }
}
