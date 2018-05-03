using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageClassDemo.Models
{
    internal interface IRestaurantService
    {
        Task DeleteAsync();
        Task<Restaurant> FindAsync(int id);
        
        Task SaveAsync(Restaurant restaurant);

    }
}
