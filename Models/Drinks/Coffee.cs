using System.Collections.Generic;

namespace DrinksDispenser.Models
{
    public class Coffee : HotDrinkBase
    {
        public Coffee() : base(2, "Coffee")
        {}

        public override List<IRecipeStep> GetRecipeSteps()
        {
            List<IRecipeStep> items = base.GetRecipeSteps();
            
            items.Add(new BrewCoffeeGrounds());

            items.Add(new PourDrinkInCup("coffee"));

            items.Add(new AddItemsToDrink("milk", "sugar"));
            
            return items;
        }
    }
}