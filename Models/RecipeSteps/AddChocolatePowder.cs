namespace DrinksDispenser.Models
{
    public class AddChocolatePowder : IRecipeStep
    {
        public string Name
        {
            get { return "Add drinking chocolate powder to the water"; }
        }

        public bool CanPerformStep()
        {
            // check for chocolate powder
            return true;
        }

        public bool PerformStep()
        {
            return true;
        }
    }
}