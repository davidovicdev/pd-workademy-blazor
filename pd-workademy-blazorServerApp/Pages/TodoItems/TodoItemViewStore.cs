using pd_workademy_blazorServerApp.Domain.Entities;
using pd_workademy_blazorServerApp.Pages.TodoItems.DTOs;

namespace pd_workademy_blazorServerApp.Pages.TodoItems
{
    public class TodoItemViewStore
    {
        private readonly TodoItemViewService _todoItemViewService;

        public TodoItemViewStore(TodoItemViewService todoItemViewService)
        {
            _todoItemViewService = todoItemViewService;
        }
        public async Task<List<TodoItem>> GetTodoItemsStoreAsync()
        {
            return await _todoItemViewService.GetTodoItemsServiceAsync();
        }
        public async Task AddTodoItemStoreAsync(AddTodoItemDTO todoItem)
        {
            await _todoItemViewService.AddTodoItemServiceAsync(todoItem);
        }
        public async Task EditTodoItemStoreAsync(EditTodoItemDTO todoItem)
        {
            await _todoItemViewService.EditTodoItemServiceAsync(todoItem);
        }
        public async Task DeleteTodoItemStoreAsync(Guid guid)
        {
            await _todoItemViewService.DeleteTodoItemServiceAsync(guid);
        }
    }
}
