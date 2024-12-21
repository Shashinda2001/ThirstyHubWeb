using ThirstyHubWeb.Models;

namespace ThirstyHubWeb.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; set; }
        IEnumerable<Drink> PerferreOrders { get; set; }

        Drink GetDrinkById(int drinkId);


    }
}
