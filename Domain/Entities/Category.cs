namespace pd_workademy_blazorServerApp.Domain.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Category() { }

        public Category(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
