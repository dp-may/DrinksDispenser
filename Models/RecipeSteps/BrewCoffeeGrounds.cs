namespace DrinksDispenser.Models
{
    public class BrewCoffeeGrounds : IRecipeStep
    {
        public string Name
        {
            get { return "Brew the coffee grounds"; }
        }

        public bool CanPerformStep()
        {
            // check for coffee grounds
            return true;
        }

        public bool PerformStep()
        {
            return true;
        }
    }
}