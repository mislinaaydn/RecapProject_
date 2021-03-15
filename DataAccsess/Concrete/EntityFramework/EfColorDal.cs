using Core.DataAccess.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;//bu eklenmemis diye context alti ciziliydi,şimdi bütün ef lere yazmalıyız de mi 
//normalde evet, ama eger EfCarDal veya bu listede istedigin sey varsa bunlari kullanirsin yeterli olur
//millet hep onu kullanmis kimse doldurmamis buralari nedense 

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarDataContext>, IColorDal//demin olusturdugumuz kizdi
    {
        public List<ColorDetailDto> GetCarDetails()
        {
            using (CarDataContext context = new CarDataContext())
            {
                var result = from r in context.Colors
                             select new ColorDetailDto
                             {
                                 ColorId = r.ColorId,
                                 ColorName = r.ColorName
                             };
               return result.ToList();
            }
            
        }
    }
}