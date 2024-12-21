using Microsoft.AspNetCore.Mvc;
using ThirstyHubWeb.Data.Interfaces;
using ThirstyHubWeb.ViewModels;

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
            ViewBag.Name = "COOOOL!";
            DrinkListViewModel vm = new DrinkListViewModel();
            vm.Drinks = _drinkRepository.Drinks;
            vm.CurrentCategory = "DrinkCategory";
            return View(vm);
        }
    }
}
