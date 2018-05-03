using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPageClassDemo.Data;

namespace RazorPageClassDemo.Models
{

    public class RestaurantService : IRestaurantService
    {
        private RestaurantDbContext _context;
        //Add our DbContext

        public RestaurantService(RestaurantDbContext context)
        {
            _context = context;
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Restaurant> FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
