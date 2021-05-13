using System.Collections.Generic;

namespace DrinksDispenser.Models
{

    public class DrinksOrderResponse
    {
        public bool IssueCreatingDrink { get; set; }
        public string Name { get; set; }
        public List<string> StepsPreformed { get; set; }
        public DrinksOrderResponse()
        {
            this.IssueCreatingDrink = false;
            this.StepsPreformed = new List<string>();            
        }
    }


}