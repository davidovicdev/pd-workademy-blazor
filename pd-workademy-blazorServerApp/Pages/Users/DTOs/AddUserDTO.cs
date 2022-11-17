namespace pd_workademy_blazorServerApp.Pages.Users.DTOs
{
    public class AddUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AddUserDTO() { }

        public AddUserDTO(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }
    }
}
