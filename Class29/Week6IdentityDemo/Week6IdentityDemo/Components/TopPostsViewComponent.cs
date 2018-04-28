using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Week6IdentityDemo.Models;

namespace Week6IdentityDemo.Components
{
    [ViewComponent]
    public class TopPostsViewComponent : ViewComponent
    {
        private Week6IdentityDemoContext _context;

        public TopPostsViewComponent(Week6IdentityDemoContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int number)
        {
            var posts = await  _context.Post.Take(number).ToListAsync();

            return View(posts);
        }
    }
}
