using eshopCar.Models;
using eshopCar.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshopCar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _carRepository;
        public HomeController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                CarOnSale = _carRepository.GetCarOnSale
            };

            return View(homeViewModel);
        }
    }
}
