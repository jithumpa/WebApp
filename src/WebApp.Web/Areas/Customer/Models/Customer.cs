using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Web.Areas.Customer.Models
{
    public class Customer
    {
        public string Name { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string District { get; set; }

        public string Gender { get; set; }
    }
}