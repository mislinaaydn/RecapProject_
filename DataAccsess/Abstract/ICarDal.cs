using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Abstract
{
   public interface ICarDal :IEntityRepository<Car>
    {
        List<Car> GetAll();
        List<Car> GetById();
        void Add(Car car);
        void Delete(Car car);
        void UpDate(Car car);

       
    }
}
