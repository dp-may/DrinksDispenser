using System;

namespace DrinksDispenser.Models
{
    public class AddItemsToDrink : IRecipeStep
    {
        string[] _items;
        public string Name
        {
            get { return $"Add {String.Join(" and ", _items)}"; }
        }

        public AddItemsToDrink(params string[] items)
        {
            _items = items;
        }

        public bool CanPerformStep()
        {
            // check items exist
            return true;
        }

        public bool PerformStep()
        {
            return true;
        }
    }
}