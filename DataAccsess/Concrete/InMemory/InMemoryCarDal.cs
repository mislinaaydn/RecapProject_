using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{CarId=1,BrandId=4,DailyPrice=120,Description="2.El",ModelYear=2020},
            new Car{CarId=2,BrandId =5,DailyPrice=340,Description="sıfır",ModelYear=2006 },
            new Car{CarId=3,BrandId =6,DailyPrice=200,Description="sıfır",ModelYear=2012 },
            new Car{CarId=4,BrandId =7,DailyPrice=450,Description="2.El",ModelYear=2019 },
            new Car{CarId=5,BrandId =8,DailyPrice=100,Description="2.El",ModelYear=2003 },

            };
        }
            
       
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        }
        public void UpDate(Car car)
        {
            Car carToUpDate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            carToUpDate.CarId = car.CarId;
            carToUpDate.DailyPrice = car.DailyPrice;
            carToUpDate.Description = car.Description;
            carToUpDate.BrandId = car.BrandId;
            carToUpDate.ModelYear = car.ModelYear;
           


        }
        public List<Car> GetById()
        {
            return _cars;
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}