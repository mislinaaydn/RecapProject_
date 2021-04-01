﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class CarDetailDto :IDto
    {
        public int CarId { get; set; }
        public string ColorName { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public  int DailyPrice { get; set; }
        public string Description { get; set; }
        public int ModelYear { get; set; }
        public string CarImagePath { get; set; }
        public DateTime CarImageDate { get; set; }
    }
}



