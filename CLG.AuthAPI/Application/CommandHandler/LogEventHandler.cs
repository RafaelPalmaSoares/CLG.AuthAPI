using CLG.AuthAPI.Application.Notifications;
using MediatR;

namespace CLG.AuthAPI.Application.CommandHandler
{
    public class LogEventHandler : INotificationHandler<SignInNotification>, INotificationHandler<ErrorNotification>
    {
        public Task Handle(SignInNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"{notification.Username} - {notification.Message} - {DateTime.UtcNow}");
            });
        }

        public Task Handle(ErrorNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"FATAL ERROR - {notification.Exception} - {notification.StackError} - {DateTime.UtcNow}");
            });
        }
    }
}
