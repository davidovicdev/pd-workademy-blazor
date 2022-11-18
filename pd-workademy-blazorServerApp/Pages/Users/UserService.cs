using pd_workademy_blazorServerApp.Pages.Users.DTOs;

namespace pd_workademy_blazorServerApp.Pages.Users
{
    public class UserService
    {
        private readonly HttpClient _http;
        public UserService(HttpClient http)
        {
            _http = http;
        }

        public async Task AddUserServiceAsync(AddUserDTO user)
        {
            await _http.PostAsJsonAsync("https://localhost:7045/User", user);
        }
        public async Task DeleteUserServiceAsync(Guid guid)
        {
            await _http.DeleteAsync($"https://localhost:7045/User?guid={guid}");
        }
    }
}
