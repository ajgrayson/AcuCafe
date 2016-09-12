using System;

namespace AcuCafe.Models.Ingredients
{
    public class Milk : IIngredient
    {
        public double Cost
        {
            get
            {
                return Constants.Costs.Milk;
            }
        }

        public string Name
        {
            get
            {
                return Constants.Ingredients.Milk;
            }
        }
    }
}
