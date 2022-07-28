using System;

namespace PlaceBooker.Application.Services.UserServices.AddUserService
{
    public class AddUserDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
