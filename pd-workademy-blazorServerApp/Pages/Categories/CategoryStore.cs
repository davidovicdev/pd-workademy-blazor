using pd_workademy_blazorServerApp.Common.Services;
using pd_workademy_blazorServerApp.Domain.Entities;
using pd_workademy_blazorServerApp.Pages.Categories.DTOs;

namespace pd_workademy_blazorServerApp.Pages.Categories
{
    public class CategoryStore
    {
        private readonly CategoryService _categoryService;
        private readonly CommonCategoryService _commonCategoryService;

        public CategoryStore(CategoryService categoryService, CommonCategoryService commonCategoryService)
        {
            _categoryService = categoryService;
            _commonCategoryService = commonCategoryService;
        }
        public async Task<List<Category>> GetCategoriesStoreAsync()
        {
            return await _commonCategoryService.GetCategoriesServiceAsync();
        }
        public async Task AddCategoryStoreAsync(AddCategoryDTO category)
        {
            await _categoryService.AddCategoryServiceAsync(category);
        }
        public async Task DeleteCategoryStoreAsync(Guid guid)
        {
            await _categoryService.DeleteCategoryServiceAsync(guid);
        }
    }
}
