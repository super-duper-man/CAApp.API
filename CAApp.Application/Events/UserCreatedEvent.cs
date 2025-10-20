using MediatR;

namespace CAApp.Application.Events
{
    public record UserCreatedEvent : INotification;
}
