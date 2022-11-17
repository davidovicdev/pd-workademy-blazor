namespace pd_workademy_blazorServerApp.Pages.TodoItems.DTOs
{
    public class EditTodoItemDTO
    {
        public EditTodoItemDTO(Guid id, string title, string? description, bool isDone, Guid categoryGuid, Guid userGuid)
        {
            Id = id;
            Title = title;
            Description = description;
            CategoryGuid = categoryGuid;
            UserGuid = userGuid;
            IsDone = isDone;
        }

        public EditTodoItemDTO() { }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public Guid CategoryGuid { get; set; }
        public Guid UserGuid { get; set; }
        public bool IsDone { get; set; }
    }
}
