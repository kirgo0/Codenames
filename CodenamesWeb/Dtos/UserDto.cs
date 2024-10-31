namespace CodenamesWeb.Dtos
{
    public class UserDto
    {
        public string UserName { get; set; }

        public UserDto() { }

        public UserDto(string userName)
        {
            UserName = userName;
        }
    }
}
