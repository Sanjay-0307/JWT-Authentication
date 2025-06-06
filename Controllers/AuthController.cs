using JWT_Auth.Data;
using JWT_Auth.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JWT_Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
       
        private readonly TokenService _tokenService;
        private readonly ApplicationDbContext _context;
        //public AuthController(TokenService tokenService) { 
        //_tokenService = tokenService;
        //}

        public AuthController(TokenService tokenService, ApplicationDbContext context) { 
        _context = context;
        _tokenService = tokenService;
        }


        

        [HttpPost("login")]
        public IActionResult Login(string username, string password) {


            var user=_context.Users.FirstOrDefault(u=>u.UserName==username && u.Password ==password);
            if (user == null)
                return BadRequest("UnAuthorized Users!");

            var token = _tokenService.GenerateToken(user.UserName, user.Role);

            //if (username == "admin" && password == "admin") {

            //    var token = _tokenService.GenerateToken(username, "Admin");
            //    return Ok(new { Token = token });
            //}
            return Ok(new { Token = token });
        }
    }
}
