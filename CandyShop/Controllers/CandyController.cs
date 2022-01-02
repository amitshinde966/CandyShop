using CandyShop.Models;
using CandyShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CandyShop.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyRepository _candyRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CandyController(ICandyRepository candyRepository, ICategoryRepository categoryRepository)
        {
            _candyRepository = candyRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Best Sellers";
            //return View(_candyRepository.GetAllCandy);
            var candyListViewModel = new CandyListViewModel();
            candyListViewModel.Candies = _candyRepository.GetAllCandy;
            candyListViewModel.CurrentCategory = "Best Sellers";
            return View(candyListViewModel);
        }

        public IActionResult Details(int id)
        {
            var candy = _candyRepository.GetCandyById(id);
            if (candy == null)
                NotFound();
            return View(candy);
        }
    }
}
