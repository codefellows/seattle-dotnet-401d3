using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Week6IdentityDemo.Models.Policies
{
    public class MinimumAgeRequirement : IAuthorizationRequirement
    {
        public int MinimumAge { get; set; }
        public MinimumAgeRequirement(int age)
        {
            MinimumAge = age;
        }
    }
}
