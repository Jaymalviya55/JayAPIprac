using Loginpagegit.Data;
using Loginpagegit.Models;
using Microsoft.AspNetCore.Mvc;
using Loginpagegit.Dto;
using Microsoft.AspNetCore.Identity.Data;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Loginpagegit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class LoginController : ControllerBase
    {
        private readonly LoginDbContext _context;
        public LoginController(LoginDbContext context)
        {

            _context = context ?? throw new ArgumentNullException(nameof(context));


        }

        [HttpPost("LoginAPIDb")]
        public IActionResult Create([FromBody] LoginRequestDto model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            // Check if a user with the provided username and email exists in the database.
            // You should also include a check for the password in a real-world scenario.
            var existingUser = _context.LoginAPIDb
                .FirstOrDefault(u => u.Username == model.Username && u.Email == model.Email);

            // If a user is found, the login is successful.
            if (existingUser != null)
            {
                // This is a placeholder for your success logic. You might return a JWT token, user info, etc.
                return Ok("Login Success");
            }
            else // If no user is found, the login fails.
            {
                return Unauthorized("Invalid credentials. Please try again.");
            }

        }
    }
}
