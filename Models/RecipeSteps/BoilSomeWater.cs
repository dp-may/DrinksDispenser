namespace DrinksDispenser.Models
{
    public class BoilSomeWater : IRecipeStep
    {
        public string Name
        {
            get { return "Boil some water"; }
        }

        public bool CanPerformStep()
        {
            // check water is available
            return true;
        }

        public bool PerformStep()
        {
            // boil water
            return true;
        }
    }
}