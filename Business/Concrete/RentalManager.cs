using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.SuccessAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.SuccessDeleted);
        }

        public IResult GetAll(Rental rental)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.SuccessListed);
        }

        public IDataResult<List<Rental>> GetByCarId(int carid)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.RentalId == carid), Messages.SuccessListed);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(), Messages.RentalListed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.UpDate(rental);
            return new SuccessResult(Messages.SuccessUpdated);
        }
    }
}
