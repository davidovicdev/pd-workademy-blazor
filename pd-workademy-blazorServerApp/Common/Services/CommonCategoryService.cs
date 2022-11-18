using pd_workademy_blazorServerApp.Domain.Entities;

namespace pd_workademy_blazorServerApp.Common.Services
{
    public class CommonCategoryService
    {
        private readonly HttpClient _http;

        public CommonCategoryService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Category>> GetCategoriesServiceAsync()
        {
            return await _http.GetFromJsonAsync<List<Category>>("https://localhost:7045/Categories");
        }
    }
}
