using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Rental :IEntity
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }  // marka 
        public int CustomerId { get; set; }  // isim soyisim
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}


