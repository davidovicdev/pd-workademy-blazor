namespace pd_workademy_blazorServerApp.Domain.Entities
{
    public class CategoryToAdd
    {
        public string Name { get; set; }

        public CategoryToAdd() { }

        public CategoryToAdd(string name)
        {
            Name = name;
        }
    }
}
