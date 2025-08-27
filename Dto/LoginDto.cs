namespace Loginpagegit.Dto
{
    public class LoginDto
    {

    public LoginDto(int id, string username, string email)
        {

            Id = id;
            UserName = username;
            Email = email;
        }
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }
    }
}
