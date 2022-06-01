using CandyShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CandyShop.Components
{
    public class ShoppingCartSum : ViewComponent
    {
        public ShoppingCartSum(ShoppingCart shoppingCart)
        {
            ShoppingCart = shoppingCart;
        }

        public ShoppingCart ShoppingCart { get; }

        public IViewComponentResult Invoke()
        {

            return View(ShoppingCart.GetShoppingCartItems().Count);
        }
    }
}
