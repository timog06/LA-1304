using BlackJackAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace BlackJackAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActionController : ControllerBase
    {
        private readonly DataContext _context;

        public ActionController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("hit")]
        public async Task<ActionResult<List<Region>>> Hit()
        {
            // Adds a new card to the Player's hand
            return Ok();
        }

        [HttpPost("stand")]
        public async Task<ActionResult<List<Region>>> Stand()
        {
            // Player's descision to not do anything
            return Ok();
        }

        [HttpPost("double")]
        public async Task<ActionResult<List<Region>>> Double()
        {
            // Doubles the player's bet and gives 1 more card, then player can't do anything else
            return Ok();
        }

        [HttpPost("split")]
        public async Task<ActionResult<List<Region>>> Split()
        {
            // If possible, split the player's cards and adds another card to the 2 separate cards
            return Ok();
        }
    }
}
