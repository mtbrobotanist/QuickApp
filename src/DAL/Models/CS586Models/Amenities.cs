using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS586MVC.Models
{
    [Flags]
    public enum Amenities
    {
        None         = 0,
        Pool         = 1,
        Laundry      = 2,
        Gym          = 4,
        Food         = 8,
        MovieTheatre = 16
    }
}
