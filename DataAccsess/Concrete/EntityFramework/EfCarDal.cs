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
        public CarDetailDto GetCarDetail(Expression<Func<Car, bool>> filter)
        {
            using (CarDataContext carContext = new CarDataContext())
            {
                IQueryable<CarDetailDto> result = from car in filter is null ? carContext.Cars : carContext.Cars.Where(filter)
                                                  join color in carContext.Colors
                                                  on car.ColorId equals color.ColorId

                                                  join brand in carContext.Brands
                                                  on car.BrandId equals brand.BrandId


                                                  select new CarDetailDto
                                                  {
                                                      CarId = car.CarId,
                                                      BrandName = brand.BrandName,
                                                      ColorName = color.ColorName,
                                                      DailyPrice = car.DailyPrice,
                                                      Description = car.Description,
                                                      ModelYear = car.ModelYear,
                                                      ModelName = car.ModelName,
                                                      CarImagePath = (from carImage in carContext.CarImages where carImage.CarId == car.CarId select carImage.ImagePath).FirstOrDefault(),

                                                      CarImageDate = (from carImage in carContext.CarImages where carImage.CarId == car.CarId select carImage.Date).ToString(),
                                                      MinFindex = car.MinFindex

                                                  };
                return result.SingleOrDefault();

            }
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
            {
                
                using (CarDataContext carContext = new CarDataContext())
                {
                IQueryable<CarDetailDto> result = from car in filter is null ? carContext.Cars : carContext.Cars.Where(filter)
                                                  join color in carContext.Colors
                                                  on car.ColorId equals color.ColorId

                                                  join brand in carContext.Brands
                                                  on car.BrandId equals brand.BrandId


                                                  select new CarDetailDto
                                                  {
                                                      CarId = car.CarId,
                                                      BrandName = brand.BrandName,
                                                      ColorName = color.ColorName,
                                                      DailyPrice = car.DailyPrice,
                                                      Description = car.Description,
                                                      ModelYear = car.ModelYear,
                                                      ModelName = car.ModelName,
                                                      CarImagePath = (from carImage in carContext.CarImages where carImage.CarId == car.CarId select carImage.ImagePath).FirstOrDefault(),
                                                     
                                                     CarImageDate = (from carImage in carContext.CarImages where carImage.CarId == car.CarId select carImage.Date).ToString(),
                                                      MinFindex = car.MinFindex

                                                  }; 
                    return result.ToList();

                }
            }
        }
}

