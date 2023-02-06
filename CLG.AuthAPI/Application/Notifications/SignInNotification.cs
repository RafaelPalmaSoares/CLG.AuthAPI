using MediatR;

namespace CLG.AuthAPI.Application.Notifications
{
    public class SignInNotification : INotification
    {
        public string Username { get; set; }
        public string Message { get; set; }
    }
}
