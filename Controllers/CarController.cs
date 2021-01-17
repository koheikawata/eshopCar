using eshopCar.Models;
using eshopCar.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshopCar.Controllers
{
    public class CarController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICarRepository _carRepository;
        public CarController(ICategoryRepository categoryRepository, ICarRepository carRepository)
        {
            _categoryRepository = categoryRepository;
            _carRepository = carRepository;
        }

        public IActionResult List()
        {
            var carListViewModel = new CarListViewModel()
            {
                Car = _carRepository.GetAllCars,
                CurrentCategory = "Bestsellers"
            };

            return View(carListViewModel);
        }

        public IActionResult Details(int id)
        {
            var car = _carRepository.GetCarById(id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }
    }
}
