using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS586MVC.Models
{
    public class PropertyUnit
    {
        public int ID { get; set; }
        public int PropertyID { get; set; }
        public int UnitID { get; set; }
        public int UnitNumber { get; set; }

        public Property Property { get; set; }
        public Unit Unit { get; set; }
    }
}
