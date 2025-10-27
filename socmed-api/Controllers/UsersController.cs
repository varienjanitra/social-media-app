using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using socmed_api.Models;

namespace socmed_api.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly VxSocmedDbContext _context;

    public UsersController(VxSocmedDbContext context)
    {
        _context = context;
    }

    [HttpGet(Name = "GetUsers")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<User>>> GetPosts()
    {
        var users = await _context.Users.ToListAsync();

        return Ok(users);
    }
}