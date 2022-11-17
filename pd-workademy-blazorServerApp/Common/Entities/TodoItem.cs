namespace pd_workademy_blazorServerApp.Domain.Entities
{
    public class TodoItem
    {
        public TodoItem(
    Guid id,
    string title,
    string? description,
    bool isDone,
    Category category,
    User user
)
        {
            Id = id;
            Title = title;
            Description = description;
            IsDone = isDone;
            Category = category;
            User = user;
        }
        public TodoItem() { }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public bool IsDone { get; set; }
        public Category Category { get; set; }
        public User User { get; set; }
    }
}
