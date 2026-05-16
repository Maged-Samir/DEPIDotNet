using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplication1.Dtos;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration _config;

        public AccountController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost("static")]
        public ActionResult<TokenDto> Login(LoginDto loginDto)
        {
            if(loginDto.UserName != "admin" || loginDto.Password != "admin123")
            {
              return Unauthorized();
            }
            //Generate Token
            var claimList = new List<Claim>
            {
               new Claim("UserName","Ahmed99"),
               new Claim("Email","Ahmed@outlook.com")
            };

            var expiry = DateTime.UtcNow.AddDays(1);

            //Get SecretKey
            var secretKeyString = _config.GetValue<string>("SecretKey");
            var secretKeyInBytes = Encoding.ASCII.GetBytes(secretKeyString);
            var secretKey = new SymmetricSecurityKey(secretKeyInBytes);

            var signingCrdentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);


            var token = new JwtSecurityToken(
                claims: claimList,
                expires: expiry,
                signingCredentials : signingCrdentials);

            var tokneHandler = new JwtSecurityTokenHandler();
            var torkenString = tokneHandler.WriteToken(token);

            return new TokenDto(torkenString,expiry);
        }

    }
}
