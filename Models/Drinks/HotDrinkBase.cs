using System;
using System.Collections.Generic;

namespace DrinksDispenser.Models
{

    public abstract class HotDrinkBase
    {
        protected string _name;
        protected int _id;
        public string Name { get { return _name; } }
        public int Id { get { return _id; } }
        
        public HotDrinkBase(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public virtual List<IRecipeStep> GetRecipeSteps()
        {
            List<IRecipeStep> items = new List<IRecipeStep>();

            items.Add(new BoilSomeWater());

            return items;
        }

        public virtual bool CanCreateDrink()
        {
            bool result = true;

            foreach (IRecipeStep step in this.GetRecipeSteps())
            {
                if (!step.CanPerformStep())
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

    }

}