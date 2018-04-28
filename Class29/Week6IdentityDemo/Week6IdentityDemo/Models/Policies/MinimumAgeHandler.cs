using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Week6IdentityDemo.Models.Policies
{
    public class MinimumAgeHandler : AuthorizationHandler<MinimumAgeRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinimumAgeRequirement requirement)
        {

            if (!context.User.HasClaim(c => c.Type == ClaimTypes.DateOfBirth))
            {
                return Task.CompletedTask;
            }

            DateTime dateOfBirth = Convert.ToDateTime(context.User.FindFirst(b => b.Type == ClaimTypes.DateOfBirth).Value);

            int userAge = DateTime.Today.Year - dateOfBirth.Year;

            if (dateOfBirth > DateTime.Today.AddYears(-userAge))
            {
                userAge--;
            }

            if (userAge >= requirement.MinimumAge)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
