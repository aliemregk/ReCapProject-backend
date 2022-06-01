using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Core.Utilities.Results.DataResults;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(CarImage carImage)
        {
            IResult result = BusinessRules.Run(
                CheckNumberOfCarsImage(carImage.CarId));

            if (result == null)
            {
                carImage.Date = DateTime.Now.ToString();
                _carImageDal.Add(carImage);
                return new SuccessResult(Messages.Added);
            }
            return result;
        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<CarImage>> GetAllByCarId(int carId)
        {
            var result = _carImageDal.GetAll(carImage => carImage.CarId == carId);
            //if (result.Count == 0)
            //{
            //    return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(carImage => carImage.ImageId == 1));
            //}
            return new SuccessDataResult<List<CarImage>>(result, Messages.Listed);
        }

        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.Updated);
        }

        private IResult CheckNumberOfCarsImage(int carId)
        {
            var result = _carImageDal.GetAll(carImage => carImage.CarId == carId).Count;
            if (result < 5)
            {
                return new SuccessResult();
            }
            return new ErrorResult(Messages.ImageNumberExceeded);
        }
    }
}
