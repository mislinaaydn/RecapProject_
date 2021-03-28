using Core.DataAccess.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarDataContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCarDetails()
        {
            using (CarDataContext context = new CarDataContext())
            {
                var result = from u in context.Customers
                             select new CustomerDetailDto
                             {
                                 CustomerId = u.CustomerId,
                                 CompanyName = u.CompanyName,
                             };
                return result.ToList();
            }

        }
    }
}
