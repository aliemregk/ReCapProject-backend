using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Results.DataResults;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetById(int id);
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetByMail(string email);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        
    }
}
