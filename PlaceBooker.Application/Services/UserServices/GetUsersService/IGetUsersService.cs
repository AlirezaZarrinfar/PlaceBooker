using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Application.Services.UserServices.GetUsersService
{
    public interface IGetUsersService
    {
        GetUserDto GetUserByUsername(string username);
    }
}
