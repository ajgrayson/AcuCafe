using AcuCafe.Contracts;
using System.Linq;

namespace AcuCafe
{
    public class Barista : IBarista
    {
        public string Prepare(Drink drink)
        {
            string message = "We are preparing the following drink for you: " + drink.Description;

            foreach(var ig in drink.Ingredients)
            {
                message += " with " + ig.Name + ",";
            }

            var ingredientNames = drink.Ingredients.Select(i => i.Name.ToLowerInvariant());
            var excludedIngredients = drink.StandardIngredients.Where(i => !ingredientNames.Contains(i.ToLowerInvariant()));
            foreach(var ig in excludedIngredients)
            {
                message += " without " + ig + ",";
            }

            return message.TrimEnd(',');
        }
    }
}
