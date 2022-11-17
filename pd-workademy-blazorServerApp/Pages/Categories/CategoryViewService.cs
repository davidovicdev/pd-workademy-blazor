using pd_workademy_blazorServerApp.Domain.Entities;
using pd_workademy_blazorServerApp.Pages.Categories.DTOs;

namespace pd_workademy_blazorServerApp.Pages.Categories
{
    public class CategoryViewService
    {
        private readonly HttpClient _http;
        public CategoryViewService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Category>> GetCategoriesServiceAsync()
        {
            return await _http.GetFromJsonAsync<List<Category>>("https://localhost:7045/Categories");
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
