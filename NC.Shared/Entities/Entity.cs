using Flunt.Notifications;

namespace NC.Shared.Entities
{
    public abstract class Entity : Notifiable
    {
        public int Id { get; private set; }
    }
}
