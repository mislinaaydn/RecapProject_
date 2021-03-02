using Business.Abstract;
using Business.Constans;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImageDal,IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(CarImage carImage)
        {
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);//mesajı burdan göndermemiz lazım
         
        }

        public IResult Delete(string path,int carImageId)
        {
            var result = _carImageDal.Get(p => p.Id == carImageId);
            if (result!=null)
            {
                var fileResult = _fileHelper.Delete(path, result.ImagePath);
                if (fileResult.Success)
                {
                    _carImageDal.Delete(result);
                    return new SuccessResult("Silme işlemi başarılı");
                }
                return new ErrorResult("Silme işlemi başarısız");
            }
            return new ErrorResult("Silme işlemi basarısız");//buradeğistirirsizsuccess olması ger
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetById(int carImageId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CarImage carImage)
        {
            throw new NotImplementedException();
        }
      
    }
}
