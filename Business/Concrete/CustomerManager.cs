using Business.Abstract;
using Business.Constans;
using Core.Entities;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
            
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
            public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.SuccessAdded);
        }

        public IResult Delete(Customer customer)

        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.SuccessDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return  new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomersListed);
        }

    

        public IDataResult<List<Customer>>GetById(int customerId)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.CustomerId == customerId), Messages.SuccessListed);
        }

        public IResult Update(Customer customer)

{
            _customerDal.UpDate(customer);
            return new SuccessResult(Messages.SuccessUpdated);

        }
    }
}
