using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccsess.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarDataContext>, IUserDal //bu da implement istedi, interfaceye bisey eklersen ona bagli olan tum classlara da implement etmelisin I olarak baslayan ana siniflarimiz
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new CarDataContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}