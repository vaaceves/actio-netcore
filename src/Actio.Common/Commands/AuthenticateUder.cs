namespace Actio.Common.Commands
{
    public class AuthenticateUder : ICommand
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}