using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string UserImage { get; set; }
    }
}
