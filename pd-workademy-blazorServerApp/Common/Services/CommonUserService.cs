using pd_workademy_blazorServerApp.Domain.Entities;

namespace pd_workademy_blazorServerApp.Common.Services
{
    public class CommonUserService
    {
        private readonly HttpClient _http;

        public CommonUserService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<User>> GetUsersServiceAsync()
        {
            return await _http.GetFromJsonAsync<List<User>>("/Users");
        }
    }
}
