using Core.DataAccess.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDataContext>, IRentalDal  
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarDataContext context = new CarDataContext())
            {
               

                // equals  ==
                var result = from renta in context.Rentals
                             join custo in context.Customers
                             on renta.CustomerId equals custo.CustomerId

                             join use in context.Users
                             on custo.UserId equals use.Id

                             join car in context.Cars
                             on renta.CarId equals car.CarId

                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId

                             select new RentalDetailDto
                             {
                                 RentalId = renta.RentalId,
                                 BrandName = brand.BrandName,
                                 FirstName = use.FirstName,
                                 LastName = use.LastName,
                                 RentDate = renta.RentDate,
                                 ReturnDate = renta.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
