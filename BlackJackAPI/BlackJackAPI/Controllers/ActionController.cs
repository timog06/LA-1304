using BlackJackAPI.Data;
using BlackJackAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpPost("hit/id={playerId}")]
        public async Task<IActionResult> Hit(int playerId)
        {
            // Logic to add a new card to the player's hand
            // 1. Get the current deck and player's hand (need game state management here)
            // 2. Deal one card from the deck to the player's hand
            // 3. Update the player's hand in the game state
            // 4. Check for player bust (hand value exceeds 21)

            return Ok(); // Updated Playerhand and 
        }

        [HttpPost("stand/id={playerId}")]
        public async Task<IActionResult> Stand(int playerId)
        {
            // Logic for the stand action
            // 1. Player decides to stand, control moves to the dealer or next player
            // 2. No changes to the player's hand, but game state needs to be updated to reflect the action

            return Ok(); // Return game state indicating the player has stood
        }

        [HttpPost("double/id={playerId}")]
        public async Task<IActionResult> Double(int playerId, int bet)
        {
            // Logic to double the player's bet and deal one more card
            // 1. Verify the player has sufficient balance to double the bet
            // 2. Double the player's bet
            // 3. Deal one card to the player's hand
            // 4. Update the game state to indicate the player's action and new hand
            // 5. Player must stand after doubling down

            return Ok(); // Return updated player hand, bet, and game status
        }

        [HttpPost("split/id={playerId}")]
        public async Task<IActionResult> Split(int playerId)
        {
            // Logic to split the player's cards if they are a pair
            // 1. Check if the player's hand is eligible for split (two cards of the same value)
            // 2. If eligible, create two separate hands and deal an additional card to each hand
            // 3. Update the game state to reflect the split hands and continue the game

            return Ok(); // Return updated game state with split hands
        }
    }
}
