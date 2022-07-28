using Microsoft.AspNet.Identity;
using PlaceBooker.Application.Services.UserServices.AddUserService;
using PlaceBooker.Application.Services.UserServices.GetUsersService;
using PlaceBooker.Application.Services.UserServices.LoginUserService;

namespace PlaceBooker.Application.UnitOfWork.UserUnitofwork
{
    public class UserUnitofwork : IUserUnitofwork
    {
        IPasswordHasher _hasher;
        public UserUnitofwork(IPasswordHasher hasher)
        {
            _hasher = hasher;
        }
        private IAddUserService _addUserService;
        public IAddUserService addUserService
        {
            get
            {
                if(_addUserService == null)
                {
                    _addUserService = new AddUserService(_hasher);
                }
                return _addUserService;
            }
        }

        private IGetUsersService _getUsersService;
        public IGetUsersService getUsersService
        {
            get
            {
                if (_getUsersService == null)
                {
                    _getUsersService = new GetUsersService();
                }
                return _getUsersService;
            }
        }

        private ILoginUserService _loginUserService;
        public ILoginUserService loginUserService
        {
            get
            {
                if (_loginUserService == null)
                {
                    _loginUserService = new LoginUserService(getUsersService, _hasher);
                }
                return _loginUserService;
            }
        }
    }
}
