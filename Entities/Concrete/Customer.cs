using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
   public class Customer :IEntity
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public int UserId { get; set; }
    }
}

