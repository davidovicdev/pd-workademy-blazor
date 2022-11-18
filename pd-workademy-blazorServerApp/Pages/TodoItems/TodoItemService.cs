using pd_workademy_blazorServerApp.Domain.Entities;
using pd_workademy_blazorServerApp.Pages.TodoItems.DTOs;

namespace pd_workademy_blazorServerApp.Pages.TodoItems
{
    public class TodoItemService
    {
        private readonly HttpClient _http;

        public TodoItemService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<TodoItem>> GetTodoItemsServiceAsync()
        {
            return await _http.GetFromJsonAsync<List<TodoItem>>("https://localhost:7045/TodoItems");
        }
        public async Task AddTodoItemServiceAsync(AddTodoItemDTO todoItem)
        {
            await _http.PostAsJsonAsync("https://localhost:7045/TodoItem", todoItem);
        }
        public async Task EditTodoItemServiceAsync(EditTodoItemDTO todoItem)
        {
            await _http.PutAsJsonAsync("https://localhost:7045/TodoItem", todoItem);
        }
        public async Task DeleteTodoItemServiceAsync(Guid guid)
        {
            await _http.DeleteAsync($"https://localhost:7045/TodoItem?guid={guid}");
        }

    }
}
