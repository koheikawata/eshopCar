using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshopCar.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars { get; }
        IEnumerable<Car> GetCarOnSale { get; }
        Car GetCarById(int carId);
    }
}
