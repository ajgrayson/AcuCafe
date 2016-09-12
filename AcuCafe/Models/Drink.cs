using AcuCafe.Exceptions;
using AcuCafe.Models;
using System.Collections.Generic;
using System.Linq;

namespace AcuCafe
{
    public abstract class Drink
    {
        public List<IIngredient> Ingredients { get; set; }

        abstract public string[] StandardIngredients { get; }

        abstract public string Description { get; }

        public Drink()
        {
            Ingredients = new List<IIngredient>();
        }

        public double Cost()
        {
            return Constants.Costs.Base + Ingredients.Sum(i => i.Cost);
        }

        public void AddIngredient(IIngredient ingredient, bool force = false)
        {
            if (StandardIngredients.Contains(ingredient.Name) || force)
            {
                Ingredients.Add(ingredient);
            }
            else
            {
                throw new InvalidIngredientException(ingredient.Name + " is invalid for this type of drink");
            }
        }
    }
}
