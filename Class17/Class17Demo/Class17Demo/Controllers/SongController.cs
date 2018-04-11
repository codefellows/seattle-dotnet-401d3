using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class17Demo.Data;
using Class17Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Class17Demo.Controllers
{
    [Route("api/[controller]")]
    public class SongController : Controller
    {
        private MusicDbContext _context;


        public SongController(MusicDbContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return _context.Songs;

        }

        // GET api/values/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> GetSong([FromRoute] int id)
        {
            var song = await _context.Songs.FirstOrDefaultAsync(s => s.Id == id);

            if (song == null)
            {
                return NotFound();
            }
            return Ok(song);
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Song song)
        {
            await _context.Songs.AddAsync(song);
            _context.SaveChanges();
            return CreatedAtRoute("Get", new { id = song.Id }, song);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
