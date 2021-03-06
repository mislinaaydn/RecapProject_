﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        IDataResult<List<User>> GetById(int userId);
        IDataResult<User> GetUserById(int userId);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<List<User>> GetAll();
        User GetByMail(string email);
        IDataResult<User> GetUserByMail(string email);

        IResult AddFindexPoint(int userId);
    }
}
