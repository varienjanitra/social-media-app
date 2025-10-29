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

    [HttpGet(Name = "GetAllPosts")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<Post>>> GetAllPosts()
    {
        var posts = await _context.Posts.ToListAsync();

        return Ok(posts);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Post>> GetPostById(long id)
    {
        var post = await _context.Posts.FindAsync(id);

        if (post == null)
        {
            return NotFound();
        }

        return Ok(post);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Post>> AddPost(Post newPost)
    {
        try
        {
            _context.Posts.Add(newPost);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPostById), new { id = newPost.Id }, newPost);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
        
    }
}
