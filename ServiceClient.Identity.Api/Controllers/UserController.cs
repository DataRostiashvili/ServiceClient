using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ServiceClient.Infrastructure.Services.Interfaces;
using ServiceClient.Infrastructure.Models.Api.Identity;
using AutoMapper;

namespace ServiceClient.Identity.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper


        #region ctor

        public UserController(
            IUserService userService,
            ITokenService tokenService,
            IMapper mapper
            )
        {
            _userService = userService;
            _tokenService = tokenService;
        }

        #endregion

        [AllowAnonymous]
        [HttpPost(nameof(Authenticate))]
        public IActionResult Authenticate(AuthenticateRequest request)
        {
            IActionResult result = Unauthorized();

            var user = _userService.Authenticate(request);

            if (user != null)
            {
                var token = _tokenService.BuildToken(user);
                result = Ok(new AuthenticateResponse(token));
            }

            return result;
        }



    }
}
