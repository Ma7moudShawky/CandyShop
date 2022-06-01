using CandyShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CandyShop.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IPieRepository pieServiceWithEntity)
        {
            PieServiceWithEntity = pieServiceWithEntity;
        }

        public IPieRepository PieServiceWithEntity { get; }

        public IActionResult Index()
        {

            return View(PieServiceWithEntity.PiesOfTheWeek);
        }
    }
}
