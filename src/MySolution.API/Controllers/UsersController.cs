using Microsoft.AspNetCore.Mvc;
using MySolution.Application.DTOs;
namespace MySolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // private readonly IUserService _userService;

        // public UsersController(IUserService userService)
        // {
        //     _userService = userService;
        // }

        // GET: api/users/{id}
        [HttpGet("{id}")]
        public ActionResult<UserDto> GetUser(int id)  // Removed async Task<>
        {
            // For demonstration, we'll use the requested ID if it's positive,
            // otherwise default to 1
            int id_data = id > 0 ? id : 1;
            
            var user = new UserDto
            {
                Id = id_data,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                CreatedAt = DateTime.UtcNow.AddDays(-30),
                UpdatedAt = DateTime.UtcNow.AddHours(-2)
            };

            return Ok(user);
        }

        // GET: api/users
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<UserDto>>> GetAllUsers()
        // {
        //     // var users = await _userService.GetAllUsersAsync();
        //     return Ok(users);
        // }

        // POST: api/users
        // [HttpPost]
        // public async Task<ActionResult<UserDto>> CreateUser([FromBody] CreateUserDto createUserDto)
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return BadRequest(ModelState);
        //     }

        //     // var createdUser = await _userService.CreateUserAsync(createUserDto);
            
        //     return CreatedAtAction(nameof(GetUser), new { id = createdUser.Id }, createdUser);
        // }

        // PUT: api/users/{id}
        // [HttpPut("{id}")]
        // public async Task<IActionResult> UpdateUser(Guid id, [FromBody] UpdateUserDto updateUserDto)
        // {
        //     if (id != updateUserDto.Id)
        //     {
        //         return BadRequest();
        //     }

        //     // await _userService.UpdateUserAsync(updateUserDto);
        //     return NoContent();
        // }

        // // DELETE: api/users/{id}
        // [HttpDelete("{id}")]
        // public async Task<IActionResult> DeleteUser(Guid id)
        // {
        //     String _data = "Mim";
        //     _data = _data + "Surgery";
        //     return NoContent();
        // }
    }
}