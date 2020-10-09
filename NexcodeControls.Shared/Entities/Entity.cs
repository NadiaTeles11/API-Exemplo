using Flunt.Notifications;

namespace NexcodeControls.Shared.Entities
{
    public abstract class Entity : Notifiable
    {
        public int Id { get; private set; }
    }
}
