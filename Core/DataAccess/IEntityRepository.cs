using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccsess
{
   public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T,bool>>filter=null);//filtreler yazmamızı sağlar
        
        List<T> GetById();
        void Add(T Entity);
        void Delete(T Entity);
        void UpDate(T Entity);

    }
}
