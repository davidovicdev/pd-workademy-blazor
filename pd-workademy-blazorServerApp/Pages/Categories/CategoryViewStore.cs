using pd_workademy_blazorServerApp.Domain.Entities;
using pd_workademy_blazorServerApp.Pages.Categories.DTOs;

namespace pd_workademy_blazorServerApp.Pages.Categories
{
    public class CategoryViewStore
    {
        private readonly CategoryViewService _categoryViewService;

        public CategoryViewStore(CategoryViewService categoryViewService)
        {
            _categoryViewService = categoryViewService;
        }
        public async Task<List<Category>> GetCategoriesStoreAsync()
        {
            return await _categoryViewService.GetCategoriesServiceAsync();
        }
        public async Task AddCategoryStoreAsync(AddCategoryDTO category)
        {
            await _categoryViewService.AddCategoryServiceAsync(category);
        }
        public async Task DeleteCategoryStoreAsync(Guid guid)
        {
            await _categoryViewService.DeleteCategoryServiceAsync(guid);
        }
    }
}
