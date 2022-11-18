using pd_workademy_blazorServerApp.Common.Services;
using pd_workademy_blazorServerApp.Domain.Entities;
using pd_workademy_blazorServerApp.Pages.TodoItems.DTOs;

namespace pd_workademy_blazorServerApp.Pages.TodoItems
{
    public class TodoItemStore
    {
        private readonly TodoItemService _todoItemService;
        private readonly CommonUserService _commonUserService;
        private readonly CommonCategoryService _commonCategoryService;

        public TodoItemStore(TodoItemService todoItemService, CommonUserService commonUserService, CommonCategoryService commonCategoryService)
        {
            _todoItemService = todoItemService;
            _commonUserService = commonUserService;
            _commonCategoryService = commonCategoryService;
        }
        public async Task<List<TodoItem>> GetTodoItemsStoreAsync()
        {
            return await _todoItemService.GetTodoItemsServiceAsync();
        }
        public async Task<List<Category>> GetCategoriesFromCommonServiceAsync()
        {
            return await _commonCategoryService.GetCategoriesServiceAsync();
        }
        public async Task<List<User>> GetUsersFromCommonServiceAsync()
        {
            return await _commonUserService.GetUsersServiceAsync();
        }
        public async Task AddTodoItemStoreAsync(AddTodoItemDTO todoItem)
        {
            await _todoItemService.AddTodoItemServiceAsync(todoItem);
        }
        public async Task EditTodoItemStoreAsync(EditTodoItemDTO todoItem)
        {
            await _todoItemService.EditTodoItemServiceAsync(todoItem);
        }
        public async Task DeleteTodoItemStoreAsync(Guid guid)
        {
            await _todoItemService.DeleteTodoItemServiceAsync(guid);
        }
    }
}
