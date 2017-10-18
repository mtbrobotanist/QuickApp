using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS586MVC.Models
{
    public class PropertyManager
    {
        public int ID { get; set; }
        public int PropertyID { get; set; }
        public int AccountPermissionRoleID { get; set; }
        
        public ICollection<Property> Properties { get; set; }
    }
}
