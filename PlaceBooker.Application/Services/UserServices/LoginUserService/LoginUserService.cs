using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNet.Identity;
using Microsoft.IdentityModel.Tokens;
using PlaceBooker.Application.Services.UserServices.GetUsersService;

namespace PlaceBooker.Application.Services.UserServices.LoginUserService
{
    public class LoginUserService : ILoginUserService
    {
        private IGetUsersService _getUsersService;
        private IPasswordHasher _passwordHasher;
        public LoginUserService(IGetUsersService getUsersService , IPasswordHasher passwordHasher)
        {
            _passwordHasher = passwordHasher;
            _getUsersService = getUsersService;
        }

        public bool Authenticate(LoginUserDto model)
        {
            try
            {
                var user = _getUsersService.GetUserByUsername(model.Username);
                if(user == null)
                {
                    return false;
                }
                var checkPassword = _passwordHasher.VerifyHashedPassword(user.Password, model.Password).ToString();
                if (checkPassword == "Failed" || user.IsActive == false)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string GenerateToken(LoginUserDto model)
        {
            try
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("9d00393c71b6e61904467f56997fe687"));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var claims = new[]
                {
                    new Claim("Id" , model.Id.ToString() ),
                    new Claim(ClaimTypes.NameIdentifier , model.Username),
                    new Claim("RegisterDate" , model.RegisterDate.ToString()),
                    new Claim("IsActive" , model.IsActive.ToString()),
                    new Claim(ClaimTypes.Role , model.Role),
                };

                var token = new JwtSecurityToken
                (
                    "https://localhost:44300",
                    "https://localhost:44300",
                    claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: credentials
                );

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch
            {
                return "";
            }
        }
    }
}
