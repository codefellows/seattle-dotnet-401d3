using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Class17Demo.Data;
using Class17Demo.Models;

namespace Class17Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/Playlist")]
    public class PlaylistController : Controller
    {
        private readonly MusicDbContext _context;

        public PlaylistController(MusicDbContext context)
        {
            _context = context;
        }

        // GET: api/Playlist
        [HttpGet]
        public IEnumerable<Playlist> GetPlaylist()
        {
            return _context.Playlist;
        }

        // GET: api/Playlist/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlaylist([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Playlist playlist = await _context.Playlist.SingleOrDefaultAsync(m => m.Id == id);
            var songs = _context.Songs.Where(s => s.Playlist.Id == playlist.Id).ToList();

            playlist.Songs = songs;

            object[] myobj = new object[]{playlist,songs};
            if (playlist == null)
            {
                return NotFound();
            }

            return Ok(playlist);
        }

        // PUT: api/Playlist/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlaylist([FromRoute] int id, [FromBody] Playlist playlist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != playlist.Id)
            {
                return BadRequest();
            }

            _context.Entry(playlist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlaylistExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Playlist
        [HttpPost]
        public async Task<IActionResult> PostPlaylist([FromBody] Playlist playlist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Playlist.Add(playlist);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlaylist", new { id = playlist.Id }, playlist);
        }

        // DELETE: api/Playlist/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlaylist([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var playlist = await _context.Playlist.SingleOrDefaultAsync(m => m.Id == id);
            if (playlist == null)
            {
                return NotFound();
            }

            _context.Playlist.Remove(playlist);
            await _context.SaveChangesAsync();

            return Ok(playlist);
        }

        private bool PlaylistExists(int id)
        {
            return _context.Playlist.Any(e => e.Id == id);
        }
    }
}