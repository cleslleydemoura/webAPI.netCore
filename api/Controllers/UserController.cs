using Microsoft.AspNetCore.Mvc;
using api.Models;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUser")]
        public IEnumerable<Usuario> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Usuario
            {
                Nome  = $"User {index}",
                Idade = $"Idade {index}"
            })
            .ToArray();
        }
    }
}