using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeReviewClass12.Data;
using Microsoft.AspNetCore.Mvc;

namespace CodeReviewClass12.Controllers
{
    public class BookController : Controller
    {
        private readonly LendingLibraryDbContext _context;

        public BookController(LendingLibraryDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}