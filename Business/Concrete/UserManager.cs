using Business.Abstract;
using Business.Constans;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService  //implement istemis - 3 tane var sen 2 tane girmissin
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal) //bu constructor
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.Listed);
        }

        User IUserService.GetByMail(string email)
        {
            throw new NotImplementedException();
        }

        List<OperationClaim> IUserService.GetClaims(User user)
        {
            throw new NotImplementedException();
        }
    }
}