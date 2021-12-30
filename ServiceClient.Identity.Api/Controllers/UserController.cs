using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace ServiceClient.Identity.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class UserController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost(nameof(Authenticate))]
        public IActionResult Authenticate()
        {

            return Ok("ok");
        }



    }
}
