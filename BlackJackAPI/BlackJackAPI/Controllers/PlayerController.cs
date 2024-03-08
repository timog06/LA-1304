using BlackJackAPI.Data;
using BlackJackAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

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

        [HttpGet("{playerId}")]
        public IActionResult GetPlayer(UserDto request)
        {
            // Logic to retrieve the player from the database would go here
            // For now, return a placeholder player for demonstration purposes

            return Ok();
        }

        /*
        [HttpPut("{playerId}")]
        public IActionResult UpdatePlayer(int playerId, [FromBody] Player playerUpdate)
        {
            // Logic to update the player information in the database would go here
            // Make sure to check if the playerId matches playerUpdate.PlayerId and handle accordingly

            return Ok();
        }

        [HttpDelete("{playerId}")]
        public IActionResult DeletePlayer(int playerId)
        {
            // Logic to delete the player from the database would go here

            return Ok();
        }*/
    }
}
