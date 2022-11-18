using pd_workademy_blazorServerApp.Pages.Categories.DTOs;

namespace pd_workademy_blazorServerApp.Pages.Categories
{
    public class CategoryService
    {
        private readonly HttpClient _http;
        public CategoryService(HttpClient http)
        {
            _http = http;
        }
        public async Task AddCategoryServiceAsync(AddCategoryDTO category)
        {
            await _http.PostAsJsonAsync("https://localhost:7045/Category", category);
        }
        public async Task DeleteCategoryServiceAsync(Guid guid)
        {
            await _http.DeleteAsync($"https://localhost:7045/Category?guid={guid}");

        }
    }
}
