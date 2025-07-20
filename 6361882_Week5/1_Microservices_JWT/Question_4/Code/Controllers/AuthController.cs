using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtLoginAPI.Models;

namespace JwtLoginAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            // Simple hardcoded role assignment
            string role = model.Username switch
            {
                "admin" => "Admin",
                "user" => "User",
                _ => null
            };

            if (model.Password == "password" && role != null)
            {
                var token = GenerateJwtToken(model.Username, role);
                return Ok(new { Token = token });
            }

            return Unauthorized("Invalid credentials");
        }


        private string GenerateJwtToken(string username, string role)
        {
           var claims = new[]
           {
              new Claim(ClaimTypes.Name, username),
              new Claim(ClaimTypes.Role, role)
           };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ThisIsASecretKeyForJwtToken,VeryVerySecure"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "MyApi",
                audience: "MyApiUsers",
                claims: claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
