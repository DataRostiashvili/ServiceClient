using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ServiceClient.Infrastructure.Services.Interfaces;
using ServiceClient.Infrastructure.Models.Api.Identity;
using AutoMapper;

namespace ServiceClient.Api.Identity.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Authorize]
    [Route("api/[controller]/[action]")]
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
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateRequest request)
        {
            IActionResult result = Unauthorized();

            var user = await _userService.AuthenticateAsync(request);

            if (user != null)
            {
                var token = _tokenService.BuildToken(user);
                result = Ok(new AuthenticateResponse(token));
            }

            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegistrationRequest request)
        {

            await _userService.Register(request);

            return CreatedAtAction(nameof(GetUser), new { userName = request.UserName });

        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UserUpdateRequest request)
        {


            await _userService.UpdateAsync(request);

            return Ok();

        }

        [HttpDelete]
        public async Task<IActionResult> Delete(UserDeleteRequest request)
        {

            await _userService.DeleteAsync(request);

            return Ok();

        }

        [HttpGet]
        public async Task<IActionResult> GetUserById(Guid userId)
        {
            IActionResult res = NotFound();
            var user = await _userService.GetUserAsync(userId);

            if (User != null)
                res = Ok(user);

            return res;

        }

        [HttpGet]
        public async Task<IActionResult> GetUser(string userName)
        {
            IActionResult res = NotFound();
            var user = await _userService.GetUserAsync(userName);

            if (User != null)
                res = Ok(user);

            return res;

        }



    }
}
