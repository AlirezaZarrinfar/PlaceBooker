using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlaceBooker.Application.Services.UserServices.AddUserService;

namespace PlaceBooker.Application.Services.UserServices.LoginUserService
{
    public interface ILoginUserService
    {
        bool Authenticate(LoginUserDto model);
        string GenerateToken(LoginUserDto model);
    }
}
