using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eshopCar.Models;

namespace eshopCar.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> CarOnSale { get; set; }
    }
}
