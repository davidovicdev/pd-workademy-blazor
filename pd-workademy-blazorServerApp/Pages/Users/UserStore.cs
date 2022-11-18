using pd_workademy_blazorServerApp.Common.Services;
using pd_workademy_blazorServerApp.Domain.Entities;
using pd_workademy_blazorServerApp.Pages.Users.DTOs;

namespace pd_workademy_blazorServerApp.Pages.Users
{
    public class UserStore
    {
        private readonly UserService _userService;
        private readonly CommonUserService _commonUserService;

        public UserStore(UserService userService, CommonUserService commonUserService)
        {
            _userService = userService;
            _commonUserService = commonUserService;
        }
        public async Task<List<User>> GetUsersStoreAsync()
        {
            return await _commonUserService.GetUsersServiceAsync();
        }
        public async Task AddUserStoreAsync(AddUserDTO user)
        {
            await _userService.AddUserServiceAsync(user);
        }
        public async Task DeleteUserStoreAsync(Guid guid)
        {
            await _userService.DeleteUserServiceAsync(guid);
        }
    }
}
