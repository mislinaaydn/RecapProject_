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
                var result = from c in context.Cars

                             join b in context.Brands
                             on c.BrandId equals b.BrandId

                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId //burayi yanlis anlamissin, burasi sana gore sekil almaz. burada Id numara geldigi icin sadece gelen numarayi name olarak getir demek icin. sana yanlis veri geliyorsa onu burada onarirsin, olmayan seyleri cagiramazsin

                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 ModelName = c.ModelName,                                 
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear,
                             };

                return result.ToList();
            }
        }
    }
}

