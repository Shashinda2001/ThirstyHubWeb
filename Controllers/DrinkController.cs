using Microsoft.AspNetCore.Mvc;
using ThirstyHubWeb.Data.Interfaces;

namespace ThirstyHubWeb.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;

        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository )
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public ViewResult List()
        {
            var drinks = _drinkRepository.Drinks;
            return View( drinks );
        }
    }
}
