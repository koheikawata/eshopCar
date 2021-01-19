using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshopCar.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Sedan" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "SUV" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Small" });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 1,
                Name = "Accord",
                Price = 3.5M,
                Description = "The Honda Accord (Japanese: ホンダ・アコード, Honda Akōdo) /əˈkɔːrd/, known as the Honda Inspire (Japanese: ホンダ・インスパイア, Honda Insupaia) in Japan for certain generations, is a series of automobiles manufactured by Honda since 1976, best known for its four-door sedan variant, which has been one of the best-selling cars in the United States since 1989. The Accord nameplate has been applied to a variety of vehicles worldwide, including coupes, station wagons, hatchbacks and a Honda Crosstour crossover.",
                CategoryId = 1,
                ImageUrl = "/Images/accord.jpg",
                ImageThumbNailUrl = "/Images/accord-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 2,
                Name = "CRV",
                Price = 4.5M,
                Description = "The Honda CR-V is a compact crossover SUV manufactured by Japanese automaker Honda since 1995 and introduced in the North American market in 1997.[1][2] It uses the Honda Civic platform with an SUV body design. The CR-V is Honda's mid-range utility vehicle, slotting between the smaller Honda HR-V and the larger North American market Honda Pilot. Honda states CR - V stands for Comfortable Runabout Vehicle, while the term Compact Recreational Vehicle is used in a British car review article that was republished by Honda.",
                CategoryId = 2,
                ImageUrl = "/Images/crv.jpg",
                ImageThumbNailUrl = "/Images/crv-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 3,
                Name = "Civic",
                Price = 2.5M,
                Description = "The Honda Civic (Japanese: ホンダ・シビック, Honda Shibikku) is a line of cars manufactured by Honda. Originally a subcompact, the Civic has gone through several generational changes, becoming both larger and more upscale, moving into the compact car segment. EPA guidelines for vehicle size class stipulate a car having combined passenger and cargo room of 110 to 119.9 cubic feet (3,110 to 3,400 L) is considered a mid-size car, and as such the tenth generation Civic sedan is technically a small-end mid-size car, although it still competes in the compact class. The Civic coupé is still considered a compact car. The Civic currently falls between the Honda City and Honda Accord.",
                CategoryId = 1,
                ImageUrl = "/Images/civic.jpg",
                ImageThumbNailUrl = "/Images/civic-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 4,
                Name = "Fit",
                Price = 1.5M,
                Description = "The Honda Fit (Japanese: ホンダ・フィット, Hepburn: Honda Fitto), also marketed as Honda Jazz, is a five-door B-segment supermini or subcompact car manufactured and marketed by Honda since 2001 and now in its fourth generation. Marketed worldwide and manufactured at ten plants in eight countries, sales reached almost 5 million by mid-2013.",
                CategoryId = 3,
                ImageUrl = "/Images/fit.jpg",
                ImageThumbNailUrl = "/Images/fit-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
        }
     }
}
