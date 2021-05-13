namespace DrinksDispenser.Models
{
    public interface IRecipeStep
    {
        string Name { get; }
        bool PerformStep();
        bool CanPerformStep();
    } 
}