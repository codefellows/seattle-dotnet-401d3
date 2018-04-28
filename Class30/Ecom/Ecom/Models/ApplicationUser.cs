using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Clans Clan { get; set; }
        public Classes Class { get; set; }
    }

    public static class ApplicationRoles
    {
        public const string Admin = "Admin";
        public const string Member = "Member";
    }

    public enum Clans { Boar, Snake, Crane, Monkey }
    public enum Classes { Fighter, Rogue, Ranger, Wizard }
}
