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
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (CarDataContext context = new CarDataContext())
            {
                var result = from c in context.Cars  //filter is   null ? context.Cars : context.Cars.Where(filter)

                             join b in context.Brands
                             on c.BrandId equals b.BrandId

                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId

                             join i in context.CarImages //suraya filtre uygulamak lazim, degerler bos ise default.jpg gitsin diye                             
                             on c.CarId equals i.CarId 

                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 ModelName = c.ModelName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear,
                                 CarImageDate = i.Date,
                                 CarImagePath = i.ImagePath
                                 //CarImageDate = (from carImage in context.CarImages where carImage.CarId == c.CarId select carImage.Date).FirstOrDefault().Da
                             }; //IQueryable<CarDetailDto>

                return result.ToList();
            }
        }
    }
}

