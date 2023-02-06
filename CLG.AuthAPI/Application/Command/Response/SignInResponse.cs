namespace CLG.AuthAPI.Application.Command.Response
{
    public class SignInResponse
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
    }
}
