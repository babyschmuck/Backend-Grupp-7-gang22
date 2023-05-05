using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApi.Services;
using WebApi.Models;
using WebApi.Models.Schemas;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }

        [HttpPost("/login")]
        public async Task<IActionResult> LoginAsync(LoginSchema schema)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                string jwtToken = await _service.LoginAsync(schema);

                return Ok(jwtToken);
            }
            catch (Exception e)
            {
                if (e.Message == "Invalid email or password.")
                    return Unauthorized();

                return StatusCode(500);
            }
        }
        [HttpPost("/register")]
        public async Task<IActionResult> RegisterAsync(RegisterSchema schema)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                //Add dto later
                string jwtToken = await _service.RegisterAsync(schema);


                return Created("", jwtToken);
            }
            catch(Exception e)
            {
                if(e.Message == "Email already exists.")
                    return Conflict();
                
                return StatusCode(500);
            }
        }


    }
}
