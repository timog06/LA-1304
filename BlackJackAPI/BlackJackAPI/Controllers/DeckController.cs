using BlackJackAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlackjackAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeckController : ControllerBase
    {
        // Skeleton was made by ChatGPT

        private readonly DataContext _context;

        public DeckController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("initialize")]
        public IActionResult InitializeDeck([FromBody] DeckInitializationRequest request)
        {
            // Initialize the deck(s) with the specified number of deck

            return Ok(new { Message = "Deck(s) initialized" });
        }
        
        [HttpGet]
        public IActionResult GetDeckState()
        {
            // Retrieve the current state of the deck from your data store
            // This is just a placeholder response with a dummy deck state
            return Ok();
        }

        // Helper method to generate a single deck of 52 cards
        private IEnumerable<string> GetSingleDeck()
        {
            var suits = new char[] { 'H', 'D', 'C', 'S' }; // Hearts, Diamonds, Clubs, Spades
            var values = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    yield return $"{value}{suit}";
                }
            }
        }
    }

    // This class represents the request data for initializing a deck
    public class DeckInitializationRequest
    {
        public int NumberOfDecks { get; set; }
    }
}
