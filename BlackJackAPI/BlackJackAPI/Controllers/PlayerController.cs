using BlackJackAPI.Data;
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

            return Ok(new UserDto
            {
                PlayerId = 1,
                Username = "IsThisUsernameTaken",
                Balance = 10000d
            });
        }

        [HttpPut("{playerId}")]
        public IActionResult UpdatePlayer(int playerId, [FromBody] Player playerUpdate)
        {
            // Logic to update the player information in the database would go here
            // Make sure to check if the playerId matches playerUpdate.PlayerId and handle accordingly

            return NoContent(); // Return 204 No Content to signify the update was successful
        }

        [HttpDelete("{playerId}")]
        public IActionResult DeletePlayer(int playerId)
        {
            // Logic to delete the player from the database would go here

            return Ok(); // Return 200 OK to signify the deletion was successful
        }
    }
}
}
