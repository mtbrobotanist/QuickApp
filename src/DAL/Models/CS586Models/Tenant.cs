using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS586MVC.Models
{
    public class Tenant
    {
        public int ID { get; set; }
        public int AccountPermissionRoleID { get; set; }

        public AccountPermissionRole AccountPermissionRole { get; set; }
    }
}
