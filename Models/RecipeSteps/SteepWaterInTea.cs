namespace DrinksDispenser.Models
{
    public class SteepWaterInTea : IRecipeStep
    {
        public string Name
        {
            get {return "Steep the water in the tea"; }
        }

        public bool CanPerformStep()
        {
            // check for tea
            return true;
        }

        public bool PerformStep()
        {
            return true;
        }
    }
}