namespace my_architecture__level_2020.Domain.Core.User
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public RoleUser Role { get; set; }
    }
}