using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using socmed_api.Models;

namespace socmed_api.Controllers;

[ApiController]
[Route("[controller]")]
public class PostsController : ControllerBase
{
    private readonly VxSocmedDbContext _context;

    public PostsController(VxSocmedDbContext context)
    {
        _context = context;
    }

    [HttpGet(Name = "GetPosts")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
    {
        var posts = await _context.Posts.ToListAsync();

        return Ok(posts);
    }
}
