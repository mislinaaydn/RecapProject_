using Core.DataAccsess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccsess.Abstract
{
   public interface IRentalDal:IEntityRepository<Rental>
    {
        List<RentalDetailDto> GetRentalDetails();
    }
}
