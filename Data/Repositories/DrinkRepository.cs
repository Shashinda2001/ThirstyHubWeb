using ThirstyHubWeb.Data.Interfaces;
using ThirstyHubWeb.Data.Models;

namespace ThirstyHubWeb.Data.Repositories
{
    public class DrinkRepository : IDrinkRepository

    {
        private readonly AppDbContext _appDbContext;
        public DrinkRepository(AppDbContext appDbContext)
        {
        _appDbContext = appDbContext;
        }
        public IEnumerable<Drink> Drinks => throw new NotImplementedException();

        public IEnumerable<Drink> PreferredDrinks => throw new NotImplementedException();

        public Drink GetDrinkById(int drinkId)
        {
            throw new NotImplementedException();
        }
    }
}
