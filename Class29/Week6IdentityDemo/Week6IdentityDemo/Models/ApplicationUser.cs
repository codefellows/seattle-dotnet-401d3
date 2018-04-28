using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Week6IdentityDemo.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string FavoriteColor { get; set; }
    }

    public static class ApplicationRoles
    {
        public const string Admin = "Admin";
        public const string Member = "Member";
    }
}
