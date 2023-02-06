using CLG.AuthAPI.Application.Command.Response;
using MediatR;

namespace CLG.AuthAPI.Application.Command.Request
{
    public class SignInRequest : IRequest<SignInResponse>
    {
        public string Username { get; set; }
        public string? Password { get; set; }
    }
}
