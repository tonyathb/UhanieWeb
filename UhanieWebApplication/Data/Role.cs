using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UhanieWebApplication.Data
{
    public class Role:IdentityUser
    {
        public string Admin { get; set; }
        public string User { get; set; }
    }
}
