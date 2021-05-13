using System.Collections.Generic;

namespace DrinksDispenser.Models
{
    public interface IRepo<T>
    {
        List<T> GetItems();
        T GetItem(int id);
    }
}