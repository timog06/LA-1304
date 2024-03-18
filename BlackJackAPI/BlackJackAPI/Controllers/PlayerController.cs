using Microsoft.AspNetCore.Mvc;
using BlackJackAPI.Data;
using BlackJackAPI.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BlackJackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly DataContext _context;

        public PlayerController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Player>>> GetAllPlayers()
        {
            var players = await _context.Players.ToListAsync();
            return Ok(players);
        }


        [HttpGet("search/un={username}")]
        public async Task<ActionResult<Player>> GetPlayerByUsername(string username)
        {
            var player = await _context.Players.FirstOrDefaultAsync(p => p.Username.ToLower() == username.ToLower());
            if (player == null)
            {
                return NotFound("Player not found.");
            }

            return Ok(player);
        }

        [HttpGet("search/id={playerId}")]
        public async Task<ActionResult<Player>> GetPlayerById(int playerId)
        {
            var player = await _context.Players.FindAsync(playerId);
            if (player == null)
            {
                return NotFound("Player not found.");
            }

            return Ok(player);
        }


        [HttpPut("update/id={playerId}")]
        public async Task<ActionResult> UpdatePlayer(int playerId, [FromBody] PlayerUpdateDto playerUpdate)
        {
            var player = await _context.Players.FindAsync(playerId);
            if (player == null)
            {
                return NotFound("Player not found.");
            }

            if (!BCrypt.Net.BCrypt.Verify(playerUpdate.Password, player.PasswordHash))
            {
                return BadRequest("Wrong password.");
            }

            player.Username = playerUpdate.Username ?? player.Username;

            if (!string.IsNullOrWhiteSpace(playerUpdate.NewPassword))
            {
                player.PasswordHash = BCrypt.Net.BCrypt.HashPassword(playerUpdate.NewPassword);
            }

            _context.Players.Update(player);
            await _context.SaveChangesAsync();

            return Ok(player);
        }

        [HttpDelete("{playerId}")]
        public async Task<ActionResult> DeletePlayer(int playerId)
        {
            var player = await _context.Players.FindAsync(playerId);
            if (player == null)
            {
                return NotFound("Player not found.");
            }

            _context.Players.Remove(player);
            await _context.SaveChangesAsync();

            return Ok($"Player {playerId} has been deleted.");
        }
    }
}
