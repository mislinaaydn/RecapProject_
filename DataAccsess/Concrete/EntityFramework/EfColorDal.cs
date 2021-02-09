using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color Entity)
        {
            
        }

        public void Delete(Color Entity)
        {
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetById()
        {
            throw new NotImplementedException();
        }

        public void UpDate(Color Entity)
        {
            throw new NotImplementedException();
        }
    }
}
