using Dapper;
using PlaceBooker.Common.Commands;
using PlaceBooker.Persistance.Connection;
using System.Linq;

namespace PlaceBooker.Application.Services.UserServices.GetUsersService
{
    public class GetUsersService : IGetUsersService
    {
        public GetUserDto GetUserByUsername(string username)
        {
            try
            {
<<<<<<< HEAD
                var data = Connection.sqlConnection.Query<GetUserDto>(UserCommands.GetUserByUsername, new
=======
                var data = Connection.sqlConnection.Query<GetUserDto>(Commands.GetUserByUsername, new
>>>>>>> 620f3a630a660e15ae17791163d1d353003aa921
                {
                    Username = username,
                }).SingleOrDefault();
                return data;
            }
            catch
            {
                return null;
            }
        }
    }
}
