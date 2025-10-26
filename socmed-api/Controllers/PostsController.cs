using Microsoft.AspNetCore.Mvc;

namespace socmed_api.Controllers;

[ApiController]
[Route("[controller]")]
public class PostsController : ControllerBase
{
    [HttpGet(Name = "GetPosts")]
    public IEnumerable<PostModel> Get()
    {
        var dummy = new DummyData();

        return dummy.DummyPosts;
    }
}
