using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ServiceClient.Infrastructure.Services.Interfaces;
using ServiceClient.Infrastructure.Models.Api.Identity;
using AutoMapper;

namespace ServiceClient.Identity.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ApiVersion("1.0")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;


        #region ctor

        public UserController(
            IUserService userService,
            ITokenService tokenService,
            IMapper mapper
            )
        {
            _userService = userService;
            _tokenService = tokenService;
            _mapper = mapper;
        }

        #endregion

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Authenticate(AuthenticateRequest request)
        {
            IActionResult result = Unauthorized();

            var user = await _userService.Authenticate(request);

            if (user != null)
            {
                var token = _tokenService.BuildToken(user);
                result = Ok(new AuthenticateResponse(token));
            }

            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegistrationRequest request)
        {
            IActionResult result = BadRequest();

            await _userService.Register(request);

            return CreatedAtAction(nameof(GetUser), new { userName = request.UserName });

        }


        [HttpGet]
        public async Task<IActionResult> GetUserById(Guid userId)
        {
            IActionResult res = NotFound();
            var user = await _userService.GetUer(userId);

            if (User != null)
                res = Ok(user);

            return res;

        }

        [HttpGet]
        public async Task<IActionResult> GetUser(string userName)
        {
            IActionResult res = NotFound();
            var user = await _userService.GetUer(userName);

            if (User != null)
                res = Ok(user);

            return res;

        }



    }
}
