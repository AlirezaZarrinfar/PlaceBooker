using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Application.Services.UserServices.AddUserService
{
    public interface IAddUserService
    {
        bool AddUser(AddUserDto model);
    }
}
