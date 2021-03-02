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
            return new SuccessResult(Messages.CarImageAdded);
          
         
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
                        return new SuccessResult(Messages.CarImageDeletedSuccess);
                    }
                    return new ErrorResult(Messages.CarImageDeletedError);
                
            }
            return new ErrorResult(Messages.CarImageDeletedError);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetById(int carImageId)
        {
            var result = _carImageDal.GetAll(p => p.CarId == carImageId);
            return new SuccessDataResult<List<CarImage>>(result);
        }

        public IResult Update(CarImage carImage)
        {
            throw new NotImplementedException();
        }
      
    }
}
