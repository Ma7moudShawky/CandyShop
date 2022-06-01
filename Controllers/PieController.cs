using CandyShop.Models;
using CandyShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CandyShop.Controllers
{
    public class PieController : Controller
    {
        public PieController(IPieRepository PieService, ICategoryRepository CategoryService)
        {
            this.PieService = PieService;
            this.CategoryService = CategoryService;
        }

        public IPieRepository PieService { get; }
        public ICategoryRepository CategoryService { get; }


        public ActionResult List(int category=-1)
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            if (category == -1)
            {
                piesListViewModel.CurrentCategory = "All Pies";
                piesListViewModel.Pies = PieService.AllPies;
            }
            else
            {
                piesListViewModel.CurrentCategory = CategoryService.GetCategoryName(category);
                piesListViewModel.Pies = PieService.AllPies.Where(p => p.Category.CategoryId == category);
            }
            return View(piesListViewModel);
        }
        public IActionResult Details(int id)
        {
            var pie = PieService.GetPieById(id);
            if (pie == null)
                return NotFound();

            return View(pie);
        }
    }
}
