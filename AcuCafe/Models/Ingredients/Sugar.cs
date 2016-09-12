using System;

namespace AcuCafe.Models.Ingredients
{
    public class Sugar : IIngredient
    {
        public double Cost
        {
            get
            {
                return Constants.Costs.Sugar;
            }
        }

        public string Name
        {
            get
            {
                return Constants.Ingredients.Sugar;
            }
        }
    }
}
