using System;

namespace PlaceBooker.Application.Services.UserServices.GetUsersService
{
    public class GetUserDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Role { get; set; }
    }
}
