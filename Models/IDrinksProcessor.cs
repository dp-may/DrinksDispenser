namespace DrinksDispenser.Models
{
    public interface IDrinksProcessor
    {
        DrinksOrderResponse CreateDrinksOrder(int id);
    }
}