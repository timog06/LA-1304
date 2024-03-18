using BlackJackAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlackJackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalanceController : ControllerBase
    {
        private readonly DataContext _context;

        public BalanceController(DataContext context)
        {
            _context = context;
        }

        [HttpPut("updateBalance/id={playerId}")]
        public async Task<ActionResult> UpdatePlayerBalance(int playerId, [FromBody] int newBalance)
        {
            var player = await _context.Players.FirstOrDefaultAsync(p => p.Id == playerId);
            if (player == null)
            {
                return NotFound("Player not found.");
            }

            player.Balance = newBalance;
            await _context.SaveChangesAsync();

            return Ok(player);
        }


        [HttpPut("updateBalance/un={username}")]
        public async Task<ActionResult> UpdatePlayerBalance(string username, [FromBody] int newBalance)
        {
            var player = await _context.Players.FirstOrDefaultAsync(p => p.Username == username);
            if (player == null)
            {
                return NotFound("Player not found.");
            }

            player.Balance = newBalance;
            await _context.SaveChangesAsync();

            return Ok(player);
        }

        [HttpPut("updateBalance100/id={playerId}")]
        public async Task<ActionResult> AddBalance100(int playerId)
        {
            var player = await _context.Players.FirstOrDefaultAsync(p => p.Id == playerId);
            if (player == null)
            {
                return NotFound("Player not found.");
            }

            player.Balance += 100;
            await _context.SaveChangesAsync();

            return Ok(player);
        }

        [HttpPut("updateBalance10/id={playerId}")]
        public async Task<ActionResult> AddBalance10(int playerId)
        {
            var player = await _context.Players.FirstOrDefaultAsync(p => p.Id == playerId);
            if (player == null)
            {
                return NotFound("Player not found.");
            }

            player.Balance += 10;
            await _context.SaveChangesAsync();

            return Ok(player);
        }
    }
}
