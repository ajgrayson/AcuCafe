using System;

namespace AcuCafe.Models.Ingredients
{
    public class Chocolate : IIngredient
    {
        public double Cost
        {
            get
            {
                return Constants.Costs.Chocolate;
            }
        }

        public string Name
        {
            get
            {
                return Constants.Ingredients.Chocolate;
            }
        }
    }
}
