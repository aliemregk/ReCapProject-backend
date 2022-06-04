using Core.Utilities.Results;
using Core.Utilities.Results.DataResults;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetAllByCarId(int id);
        IResult Add(CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update(CarImage carImage);
    }
}
