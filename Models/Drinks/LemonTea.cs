using System.Collections.Generic;

namespace DrinksDispenser.Models
{

    public class LemonTea : HotDrinkBase
    {
        public LemonTea() : base(1, "Lemon Tea")
        {}

        public override List<IRecipeStep> GetRecipeSteps()
        {
            List<IRecipeStep> items = base.GetRecipeSteps();
            
            items.Add(new SteepWaterInTea());

            items.Add(new PourDrinkInCup("tea"));

            items.Add(new AddItemsToDrink("lemon"));
            
            return items;
        }

    }

}