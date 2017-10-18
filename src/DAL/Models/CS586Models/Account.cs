using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS586MVC.Models
{
    public class Account
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PhoneAttribute PhoneNumber { get; set; }
        public string PassWordHash { get; set; }
    }
}
