namespace WebApplication1.Dtos
{
    public class TokenDto
    {
        public TokenDto(string token, DateTime expiry)
        {
            Token = token;
            Expiry = expiry;
        }

        public string Token { get; set; }
        public DateTime Expiry { get; set; }
    }
}
