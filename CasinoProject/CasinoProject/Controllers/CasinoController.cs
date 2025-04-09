using CasinoProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CasinoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasinoController : ControllerBase
    {
        private readonly CasinoContext _context = new CasinoContext();

        [HttpGet("/players/number")]
        public async Task<IActionResult> GetNumberOfPlayers() 
        {
            return Ok(await _context.Players
                .CountAsync());
        }

        [HttpGet("/players/amount/{1000}")]
        public async Task<IActionResult> GetPlayersWith1000(int money)
        {
            return Ok(await _context.Players
                .Where(p => p.Amount >= money)
                .ToListAsync());
        }

        [HttpGet("/games/sort")]
        public async Task<IActionResult> GetGamesSort()
        {
            return Ok(await _context.Plays
                .OrderByDescending(a => a.Amount)
                .Select(a => new { a.GameId, a.Amount})
                .ToListAsync());
        }

        [HttpGet("/games/player/{3}")]
        public async Task<IActionResult> GetGamesPlayer3(int xplayer)
        {
            return Ok(await _context.Plays
                .Where(a => a.PlayerId == xplayer)
                .Select(a => new { a.GameId })
                .ToListAsync());
        }
        [HttpDelete("/player/{Id}")]
        public async Task<IActionResult> GetPlayer12(int xplayer)
        {
            return Ok(await _context.Players
                .Where(a => a.Id == xplayer).ExecuteDeleteAsync());
                
                
        }
    }
}
