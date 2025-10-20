using MediatR;
using Microsoft.Extensions.Logging;

namespace CAApp.Application.Events
{
    public class SendEmailEventHandler(ILogger<SendEmailEventHandler> logger) : INotificationHandler<UserCreatedEvent>
    {
        public async Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
        {
            logger.LogInformation("User created: Send email start");

            await Task.Delay(2000, cancellationToken);

            logger.LogInformation("User created: Send email done");
        }
    }
}
