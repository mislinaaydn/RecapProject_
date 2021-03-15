using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length >= 2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Yeni marka eklendi.");
            }
            else
            {
                Console.WriteLine("Minimum iki karakter girmelisiniz.");
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka silindi.");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
        }

        public Brand getById(int BrandId)
        {
            return _brandDal.Get(c => c.BrandId == BrandId);
        }

        public void Update(Brand brand)
        {
            _brandDal.UpDate(brand);
            Console.WriteLine("Marka güncellendi.");
        }
    }
}
