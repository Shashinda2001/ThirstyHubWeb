using ThirstyHubWeb.Data.Models;

namespace ThirstyHubWeb.Data.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get;  }
        IEnumerable<Drink> PreferredDrinks { get;  }

        Drink GetDrinkById(int drinkId);


    }
}
