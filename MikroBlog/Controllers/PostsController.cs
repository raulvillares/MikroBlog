using Microsoft.AspNetCore.Mvc;

namespace MikroBlog.Controllers;


[ApiController]
[Route("{user}/posts")]
public class PostsController : ControllerBase
{
    [HttpGet]
    public string Get(string user)
    {
        return $"hello {user}";
    }
}