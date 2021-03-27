using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.NewFolder;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using DataAccsess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Performance;

namespace Business.Concrete
{
    public class CarManager : ICarService
          {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [CacheRemoveAspect("ICarService.Get")]
        //[SecuredOperation("car.add , admin")]
       // [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            if (car.ModelName.Length < 2) //bu da ismiydi modeli yaptim
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);

        }

        
        public IResult Delete(Car car)
        {
            throw new NotImplementedException();
        }
        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);
        }
        [PerformanceAspect(10)]
        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return  new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }
        
        public IDataResult<List<Car>> GetByModelYear(string year)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }
        [CacheRemoveAspect("ICarService.Get")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }
        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            Add(car);
            if (car.DailyPrice<100)
            {
                throw new Exception("");
            }
            Add(car);
            return null;
        }

    }
}





