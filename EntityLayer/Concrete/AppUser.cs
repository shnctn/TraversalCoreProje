using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser: IdentityUser<int>
    {
        public string imageUrl { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public string gender { get; set; }
    }
}
