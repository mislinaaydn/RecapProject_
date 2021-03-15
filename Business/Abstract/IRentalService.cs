using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IResult GetAll(Rental rental);

        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IDataResult<List<Rental>> GetByCarId(int carid);
    }
}
