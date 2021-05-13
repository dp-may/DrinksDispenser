using System.Collections.Generic;

namespace DrinksDispenser.Models
{
    public class Chocolate : HotDrinkBase
    {
        public Chocolate() : base(3, "Chocolate")
        {}

        public override List<IRecipeStep> GetRecipeSteps()
        {
            List<IRecipeStep> items = base.GetRecipeSteps();

            items.Add(new AddChocolatePowder());

            items.Add(new PourDrinkInCup("chocolate"));

            return items;
        }

    }

}