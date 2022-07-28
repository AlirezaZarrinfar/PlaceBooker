using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlaceBooker.Application.Services.UserServices.AddUserService;
using PlaceBooker.Application.Services.UserServices.LoginUserService;
using PlaceBooker.Application.UnitOfWork.UserUnitofwork;
using PlaceBooker.Common.ViewModels.UserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceBooker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IUserUnitofwork _userUnitofwork;
        public AuthController(IUserUnitofwork userUnitofwork)
        {
            _userUnitofwork = userUnitofwork;
        }


        [HttpPost("SignUp")]
        public IActionResult SignUp(SignUpUserVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var user = new AddUserDto { Username = model.Username, Password = model.Password , Role = "Customer" };
            var res = _userUnitofwork.addUserService.AddUser(user);
            return Ok(res);
        }


        [HttpPost("Login")]
        public IActionResult Login(LoginUserVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var auth = _userUnitofwork.loginUserService.Authenticate(new LoginUserDto
            {
                Username = model.Username,
                Password = model.Password
            });

            if (!auth)
            {
                return Unauthorized();
            }

            var user = _userUnitofwork.getUsersService.GetUserByUsername(model.Username);

            var token = _userUnitofwork.loginUserService.GenerateToken(new LoginUserDto
            {
                Username = user.Username,
                Password = user.Password,
                RegisterDate = user.RegisterDate,
                IsActive = user.IsActive,
                Role = user.Role,
                Id = user.Id
            });
            return Ok(token);
        }
    }
}
