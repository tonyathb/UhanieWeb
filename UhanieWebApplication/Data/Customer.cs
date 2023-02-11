using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UhanieWebApplication.Data
{
    public class Customer:IdentityUser
    {
        public string LastName { get; set; }
        public DateTime RegisterOn { get; set; }
        public ICollection<OrderFlower> OrderFlowers { get; set; }
        public ICollection<OrderBouquet> OrderBouquets { get; set; }
    }
}
