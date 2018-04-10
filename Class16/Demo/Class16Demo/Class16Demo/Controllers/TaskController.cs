using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class16Demo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Class16Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/Task")]
    public class TaskController : Controller
    {
        private TaskDbContext _context;

        public TaskController(TaskDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"value1", "value2", "cat"};
        }

        [HttpGet("{id:int?}")]
        public IActionResult Get(int id)
        {
           var myTask = _context.Tasks.FirstOrDefault(t => t.ID == id);
            return Ok(myTask);
        }
    }
}