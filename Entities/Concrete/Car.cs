using Entities.Abstarct;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Car : IEntity
    {
        public int CarId { get; set; }
        public int  BrandId { get; set; }
        public int ColorId { get; set; }
        public int CarModelYear { get; set; }
        public int CarDailyPrice { get; set; }
        public string CarDescription { get; set; }

    }
}

