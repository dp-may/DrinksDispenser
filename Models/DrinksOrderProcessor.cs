namespace DrinksDispenser.Models
{

    public class DrinksOrderProcessor : IDrinksProcessor
    {
        private readonly HotDrinkRepo _repo;

        public DrinksOrderProcessor(HotDrinkRepo repo)
        {
            _repo = repo;
        }
        public DrinksOrderResponse CreateDrinksOrder(int id)
        {
            DrinksOrderResponse response = new DrinksOrderResponse();

            HotDrinkBase drink = _repo.GetItem(id);

            if (drink != null)
            {
                
                if (drink.CanCreateDrink())
                {
                    response.Name = drink.Name;

                    foreach (IRecipeStep step in drink.GetRecipeSteps())
                    {

                        if (step.PerformStep()) 
                        {
                            response.StepsPreformed.Add(step.Name);
                        }
                        else
                        {
                            response.IssueCreatingDrink = true;
                            break;
                        }
    
                    }
                } 
                else 
                {
                    response.IssueCreatingDrink = true;
                }

            }

            return response;
        }



    }

}