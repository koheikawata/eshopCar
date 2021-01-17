using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eshopCar.Models;

namespace eshopCar.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> Car { get; set; }
        public string CurrentCategory { get; set; }
    }
}
