using Core.DataAccsess;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
       
        List<OperationClaim> GetClaims(User user);
    }
}

