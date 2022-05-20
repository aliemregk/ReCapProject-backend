using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //AddCars(carManager);
            //GetCarDetails(carManager);

            //AddColors(colorManager);
            //DeleteColor(colorManager);
            //UpdateColor(colorManager);

            //AddBrands(brandManager);
            //DeleteBrand(brandManager);
            //UpdateBrand(brandManager);
        }

        private static void GetCarDetails(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + " -- " + car.ColorName + " -- " + car.BrandName);
            }
        }

        private static void AddBrands(BrandManager brandManager)
        {
            Brand brand1 = new Brand
            {
                BrandId = 1,
                BrandName = "Honda"
            };
            Brand brand2 = new Brand
            {
                BrandId = 2,
                BrandName = "Toyota"
            };
            Brand brand3 = new Brand
            {
                BrandId = 3,
                BrandName = "Ford"
            };
            Brand brand4 = new Brand
            {
                BrandId = 4,
                BrandName = "Ferrari"
            };

            //brandManager.Add(brand1);
            //brandManager.Add(brand2);
            brandManager.Add(brand3);
            //brandManager.Add(brand4);
            Console.WriteLine("Brands added");
        }
        private static void UpdateBrand(BrandManager brandManager)
        {
            Brand brand = new Brand
            {
                BrandId = 3,
                BrandName = "Peugeot"
            };
            brandManager.Update(brand);
            Console.WriteLine("Brand updated.");

        }
        private static void DeleteBrand(BrandManager brandManager)
        {
            Brand brand = new Brand
            {
                BrandId = 3
            };
            brandManager.Delete(brand);
            Console.WriteLine("Brand deleted.");
        }
        private static void AddColors(ColorManager colorManager)
        {
            Color color1 = new Color
            {
                ColorId = 1,
                ColorName = "White",
            };
            Color color2 = new Color
            {
                ColorId = 2,
                ColorName = "Black",
            };
            Color color3 = new Color
            {
                ColorId = 3,
                ColorName = "Red",
            };
            Color color4 = new Color
            {
                ColorId = 4,
                ColorName = "Blue",
            };

            colorManager.Add(color1);
            //colorManager.Add(color2);
            //colorManager.Add(color3);
            //colorManager.Add(color4);
            Console.WriteLine("Colors added");
        }
        private static void DeleteColor(ColorManager colorManager)
        {
            Color color = new Color
            {
                ColorId = 1
            };
            colorManager.Delete(color);
            Console.WriteLine("Color deleted.");
        }
        private static void UpdateColor(ColorManager colorManager)
        {
            Color color = new Color
            {
                ColorId = 1,
                ColorName = "Purple"
            };
            colorManager.Update(color);
            Console.WriteLine("Color updated.");
        }
        private static void AddCars(CarManager carManager)
        {
            Car car1 = new Car
            {
                CarId = 1,
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 500,
                Description = "Honda Civic",
                ModelYear = 2015
            };

            Car car2 = new Car
            {
                CarId = 2,
                BrandId = 2,
                ColorId = 2,
                DailyPrice = 400,
                Description = "Toyota Yaris",
                ModelYear = 2016
            };

            Car car3 = new Car
            {
                CarId = 3,
                BrandId = 2,
                ColorId = 3,
                DailyPrice = 550,
                Description = "Toyota Corolla",
                ModelYear = 2017
            };
            Car car4 = new Car
            {
                CarId = 4,
                BrandId = 4,
                ColorId = 4,
                DailyPrice = 900,
                Description = "Ferrari LaFerrari",
                ModelYear = 2015
            };

            carManager.Add(car1);
            carManager.Add(car2);
            carManager.Add(car3);
            carManager.Add(car4);
            Console.WriteLine("Cars added");
        }
    }
}
