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
                var data = Connection.sqlConnection.Query<GetUserDto>(Commands.GetUserByUsername, new
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
