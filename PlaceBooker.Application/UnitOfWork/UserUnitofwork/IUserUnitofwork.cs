using PlaceBooker.Application.Services.UserServices.AddUserService;
using PlaceBooker.Application.Services.UserServices.GetUsersService;
using PlaceBooker.Application.Services.UserServices.LoginUserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Application.UnitOfWork.UserUnitofwork
{
    public interface IUserUnitofwork
    {
        public IAddUserService addUserService { get; }
        public IGetUsersService getUsersService { get; }
        public ILoginUserService loginUserService { get; }
    }
}
