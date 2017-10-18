using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS586MVC.Models
{
    public class Property
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public int Amenities { get; set; } // pool, laundry, etc.

        public ICollection<PropertyUnit> PropertyUnits { get; set; }
    }
}
