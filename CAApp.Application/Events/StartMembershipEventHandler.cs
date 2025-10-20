using MediatR;
using Microsoft.Extensions.Logging;

namespace CAApp.Application.Events
{
    public class StartMembershipEventHandler(ILogger<StartMembershipEventHandler> logger) : INotificationHandler<UserCreatedEvent>
    {
        public async Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
        {
            logger.LogInformation("User created: membership started");

            await Task.Delay(5000, cancellationToken);

            logger.LogInformation("User created: membership started");
        }
    }
}
