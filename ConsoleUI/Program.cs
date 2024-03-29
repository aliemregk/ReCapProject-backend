﻿using Business.Concrete;
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
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            UserManager userManager = new UserManager(new EfUserDal());

            //AddCars(carManager);
            //GetCarDetails(carManager);

            //AddColors(colorManager);
            //DeleteColor(colorManager);
            //UpdateColor(colorManager);

            //AddBrands(brandManager);
            //DeleteBrand(brandManager);
            //UpdateBrand(brandManager);


            //AddUser(userManager);
            //AddCustomer(customerManager);

            //AddRental(rentalManager);
            GetRental(rentalManager);

        }

        private static void AddRental(RentalManager rentalManager)
        {
            Rental rental1 = new Rental
            {
                CarId = 3,
                CustomerId = 1,
                RentalId = 2,
                RentDate = "28 Mayıs 2018",
                ReturnDate = "5 Haziran 2018"
            };

            rentalManager.Add(rental1);
        }

        private static void GetRental(RentalManager rentalManager)
        {
            var result = rentalManager.GetAll();
            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.RentalId + " -- " + rental.CarId + " -- " + rental.CustomerId
                         + " -- " + rental.RentDate + " -- " + rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void AddCustomer(CustomerManager customerManager)
        {
            Customer customer1 = new Customer
            {
                CustomerId = 1,
                UserId = 1,
                CompanyName = "Company A"
            };
            Customer customer2 = new Customer
            {
                CustomerId = 2,
                UserId = 2,
                CompanyName = "Company B"
            };
            Customer customer3 = new Customer
            {
                CustomerId = 3,
                UserId = 3,
                CompanyName = "Company C"
            };
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
        }
        private static void AddUser(UserManager userManager)
        {
            User user1 = new User
            {
                UserId = 1,
                FirstName = "User1",
                LastName = "User1",
                Email = "user1@email.com",
                Password = "1234"
            };
            User user2 = new User
            {
                UserId = 2,
                FirstName = "User2",
                LastName = "User2",
                Email = "user2@email.com",
                Password = "1234"
            };
            User user3 = new User
            {
                UserId = 3,
                FirstName = "User3",
                LastName = "User3",
                Email = "user3@email.com",
                Password = "1234"
            };
            userManager.Add(user1);
            userManager.Add(user2);
            userManager.Add(user3);
        }
        private static void GetCarDetails(CarManager carManager)
        {
            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + " -- " + car.ColorName + " -- " + car.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void AddBrand(BrandManager brandManager)
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
        private static void AddColor(ColorManager colorManager)
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
        private static void AddCar(CarManager carManager)
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
                CarId = 5,
                BrandId = 4,
                ColorId = 3,
                DailyPrice = 950,
                Description = "F",
                ModelYear = 2016
            };

            carManager.Add(car1);
            carManager.Add(car2);
            carManager.Add(car3);
            carManager.Add(car4);
        }
    }
}
