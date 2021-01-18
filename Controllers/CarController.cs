using eshopCar.Components;
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

        public ViewResult List(string category)
        {
            IEnumerable<Car> cars;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                cars = _carRepository.GetAllCars.OrderBy(c => c.CarId);
                currentCategory = "All cars";
            }
            else
            {
                cars = _carRepository.GetAllCars.Where(c => c.Category.CategoryName == category);
                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new CarListViewModel
            {
                Car = cars,
                CurrentCategory = currentCategory
            });
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
