using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryProductDal
    {
        //List<Car> _cars;

        //public InMemoryProductDal()
        //{
        //    _cars = new List<Car> { 
        //        new Car { CarId = 1, BrandId = 2, ColorId = 3, DailyPrice = 200, ModelYear = 2014, Description = "2014 Model Ford Fiesta" },
        //        new Car { CarId = 2, BrandId = 2, ColorId = 1, DailyPrice = 250, ModelYear = 2015, Description = "2015 Model Ford Fiesta" },
        //        new Car { CarId = 3, BrandId = 2, ColorId = 2, DailyPrice = 270, ModelYear = 2016, Description = "2016 Model Ford Fiesta" },
        //        new Car { CarId = 4, BrandId = 2, ColorId = 1, DailyPrice = 300, ModelYear = 2017, Description = "2017 Model Ford Fiesta" },
        //        new Car { CarId = 5, BrandId = 2, ColorId = 3, DailyPrice = 350, ModelYear = 2018, Description = "2018 Model Ford Fiesta" }
        //    };
        //}

        //public void Add(Car car)
        //{
        //    _cars.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
        //    _cars.Remove(carToDelete);
        //}

        //public Car Get(Expression<Func<Car, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Car> GetAll()
        //{
        //    return _cars;
        //}

        //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Car> GetAllByCategory(int brandId)
        //{
        //    return _cars.Where(p => p.BrandId == brandId).ToList();
        //}

        //public void Update(Car car)
        //{
        //    Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
        //    carToUpdate.CarId = car.CarId;
        //    carToUpdate.BrandId = car.BrandId;
        //    carToUpdate.ColorId = car.ColorId;
        //    carToUpdate.DailyPrice = car.DailyPrice;
        //    carToUpdate.Description = car.Description;
        //}
    }
}
