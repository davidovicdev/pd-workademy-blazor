using pd_workademy_blazorServerApp.Domain.Entities;

namespace pd_workademy_blazorServerApp.Pages.Users
{
    public class UserViewStore
    {
        private readonly UserViewService _userViewService;

        public UserViewStore(UserViewService userViewService)
        {
            _userViewService = userViewService;
        }
        public async Task<List<User>> GetUsersStoreAsync()
        {
            return await _userViewService.GetUsersServiceAsync();
        }
    }
}
