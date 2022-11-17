namespace pd_workademy_blazorServerApp.Pages.Categories.DTOs
{
    public class AddCategoryDTO
    {
        public string Name { get; set; }

        public AddCategoryDTO() { }

        public AddCategoryDTO(string name)
        {
            Name = name;
        }
    }
}
