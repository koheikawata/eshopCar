using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshopCar.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            new Category{CategoryId=1, CategoryName="Sedan", CategoryDescription="Sedan is the category of "},
            new Category{CategoryId=2, CategoryName="Suv", CategoryDescription="Suv is the category of "},
            new Category{CategoryId=3, CategoryName="Small", CategoryDescription="Small is the category of "}
        };
    }
}
