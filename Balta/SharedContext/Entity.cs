using Balta.NotificationContext;

namespace Balta.SharedContext
{
    public abstract class Entity : Notifiable
    {
        public Guid Id { get; set; }
        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}