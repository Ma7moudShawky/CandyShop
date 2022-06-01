using CandyShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CandyShop.Components
{
    public class CategoryDropDown : ViewComponent

    {
        public CategoryDropDown(ICategoryRepository categoryService)
        {
            CategoryService = categoryService;
        }

        public ICategoryRepository CategoryService { get; }

        public IViewComponentResult Invoke()
        {

            return View(CategoryService.AllCategories.OrderBy(c=>c.CategoryName));
        }
    }
}
