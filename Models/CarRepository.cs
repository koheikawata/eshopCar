using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshopCar.Models
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _appDbContext;
        public CarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Car> GetAllCars
        {
            get
            {
                return _appDbContext.Cars.Include(c => c.Category);
            }
        }

        public IEnumerable<Car> GetCarOnSale
        {
            get
            {
                return _appDbContext.Cars.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public Car GetCarById(int carId)
        {
            return _appDbContext.Cars.Include(c => c.Category).FirstOrDefault(c => c.CarId == carId);
        }
    }
}
