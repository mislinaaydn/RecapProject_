using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Abstract
{
   public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);//filtreler yazmamızı sağlar

        T Get(Expression<Func<T, bool>> filter);
        List<T> GetById();
        void Add(T Entity);
        void Delete(T Entity);
        void UpDate(T Entity);

    }
}
