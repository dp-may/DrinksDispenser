namespace DrinksDispenser.Models
{
    public class PourDrinkInCup : IRecipeStep
    {
        private readonly string _drinkName;
        public string Name 
        {
            get { return $"Pour {_drinkName} into cup" ; }
        }

        public PourDrinkInCup(string drinkName)
        {
            _drinkName = drinkName;
        }
        public bool CanPerformStep()
        {
            // check cups
            return true;
        }
        public bool PerformStep()
        {
            return true;
        }
    }
}