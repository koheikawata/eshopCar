using eshopCar.Models;
using eshopCar.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshopCar.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ICarRepository carRepository, ShoppingCart shoppingCart)
        {
            _carRepository = carRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();
            var shoppingCartViewModel = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int carId)
        {
            var selectedCar = _carRepository.GetAllCars.FirstOrDefault(c => c.CarId == carId);
            if (selectedCar != null)
            {
                _shoppingCart.AddToCart(selectedCar, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int carId)
        {
            var selectedCar = _carRepository.GetAllCars.FirstOrDefault(c => c.CarId == carId);
            if (selectedCar != null)
            {
                _shoppingCart.RemoveFromCart(selectedCar);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();

            return RedirectToAction("Index");
        }
    }
}
