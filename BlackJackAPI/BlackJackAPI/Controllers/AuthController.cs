using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BlackJackAPI.Entities;
using BlackJackAPI.Data;

namespace BlackJackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public AuthController(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpPost("Register")]
        public ActionResult<Player> Register(UserDto request)
        {
            if (_context.Players.Any(p => p.Username == request.Username))
            {
                return BadRequest("User already exists.");
            }

            var player = new Player
            {
                Username = request.Username,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
                Balance = 0
            };

            _context.Players.Add(player);
            _context.SaveChanges();

            return Ok(player);
        }


        [HttpPost("Login")]
        public ActionResult<string> Login(UserDto request)
        {
            var player = _context.Players.FirstOrDefault(p => p.Username == request.Username);

            if (player == null)
            {
                return NotFound("User not found");
            }

            if (!BCrypt.Net.BCrypt.Verify(request.Password, player.PasswordHash))
            {
                return BadRequest("Wrong Password");
            }

            string token = CreateToken(player);

            return Ok(token);
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: creds
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
