﻿using Core.Utilities.Results;
using Core.Utilities.Results.DataResults;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);
    }
}
