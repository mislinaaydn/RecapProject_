using Core.DataAccess.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDataContext>, IRentalDal  //bu bir yerde nreferans aliyor hatali cagiriyor
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarDataContext context = new CarDataContext())
            {
                var result = from a in context.Rentals
                             join b in context.Customers
                             on a.CustomerId equals b.CustomerId

                             select new RentalDetailDto
                             {
                                 CompanyName = b.CompanyName,
                                 Id = a.Id,
                                 ReturnDate = a.ReturnDate,
                                 RentDate = a.RentDate,
                             };
                return result.ToList();
            }
        }
    }
}
