using System.Collections.Generic;

namespace DrinksDispenser.Models
{
    public class HotDrinkRepo : IRepo<HotDrinkBase>
    {
        private static readonly List<HotDrinkBase> _hotDrinks = new List<HotDrinkBase>
        {
            new LemonTea(), new Coffee(), new Chocolate()
        };

        public List<HotDrinkBase> GetItems()
        {
            return _hotDrinks;
        }

        public HotDrinkBase GetItem(int id)
        {
            return _hotDrinks.Find(item => item.Id == id);
        }
    }
}