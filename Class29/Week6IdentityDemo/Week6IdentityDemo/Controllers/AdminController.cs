using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Week6IdentityDemo.Controllers
{
    [Authorize(Policy = "Over21")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}