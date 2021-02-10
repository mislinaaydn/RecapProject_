using Core.DataAccess.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDataContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarDataContext context = new CarDataContext())
            {
                var result = from c in context.Car
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             join cl in context.Color
                             on c.ColorId equals cl.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear
                             };

                return result.ToList(); ;
            }
        }
    }
}
