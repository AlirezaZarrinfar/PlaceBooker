using Dapper;
using Microsoft.AspNet.Identity;
using PlaceBooker.Common.Commands;
using PlaceBooker.Persistance.Connection;
using System;

namespace PlaceBooker.Application.Services.UserServices.AddUserService
{
    public class AddUserService : IAddUserService
    {
        private readonly IPasswordHasher _hasher;
        public AddUserService(IPasswordHasher hasher)
        {
            _hasher = hasher;
        }
        public bool AddUser(AddUserDto model)
        {
            try
            {
                string hashedPassword = _hasher.HashPassword(model.Password);
                Connection.sqlConnection.Query<AddUserDto>(UserCommands.AddUser, new
                {
                    Username = model.Username,
                    Password = hashedPassword,
                    IsActive = true,
                    RegisterTime = DateTime.Now,
                    Role = model.Role,
                });
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
