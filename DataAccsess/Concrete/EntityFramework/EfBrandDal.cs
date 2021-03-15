using Core.DataAccess.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, CarDataContext>, IBrandDal
    {
        public List<BrandDetailDto> GetCarDetails()
        {
            using (CarDataContext context = new CarDataContext())
            {
                var result = from r in context.Brands
                             select new BrandDetailDto
                             {
                                 BrandId = r.BrandId,
                                 BrandName = r.BrandName
                             };
                return result.ToList();
            }

        }
    }
}
