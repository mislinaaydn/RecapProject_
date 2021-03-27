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
            _userDal.Add(user);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.Listed);
        }
        //buraları public yapmamışşın
       public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

      public  List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }
    }
}