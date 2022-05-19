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
                CarId = 3,
                BrandId = 1,
                ColorId = 3,
                DailyPrice = 0,
                Description = "Toyota Yaris",
                ModelYear = 2010
            };
            /*
            carManager.Add(car1);
            carManager.Add(car2);
            carManager.Add(car3);
            Console.WriteLine("added");
            */
            /*
            carManager.Delete(car1);
            Console.WriteLine("deleted");
            */
            carManager.Add(car4);
        }
    }
}
