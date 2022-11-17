namespace pd_workademy_blazorServerApp.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User() { }

        public User(Guid id, string fname, string lname)
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
        }
    }
}
