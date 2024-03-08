namespace BlackJackAPI.Entities
{
    public class PlayerUpdateDto
    {
        public string Username { get; set; }
        public int Balance { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
    }
}
