﻿using Core.Entities;

namespace Entities.Concrete
{
   public class Car :IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public string ModelName { get; set; }
        public  int DailyPrice { get; set; }
        public string Description { get; set; }
        public int MinFindex { get; set; }
    }
}