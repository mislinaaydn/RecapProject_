using Business.Abstract;
using DataAccsess.Abstract;
using DataAccsess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
          {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Başarıyla eklendi");
            }
            else
            {
                Console.WriteLine("Günlük kiralama ücreti 0 TL'den büyük olmalıdır.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Başarıyla silindi.");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
            
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int ColorId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public Car GetById(int id)
        {
            throw new NotImplementedException();
        }

       
        public List<Car> GetByModelYear(string year)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            _carDal.UpDate(car);
            Console.WriteLine("Başarıyla güncellendi.");
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
