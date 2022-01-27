using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Student : Entity
    {
        public User User { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(s => !s.IsInactive);

        public void CreateSubscriptions(Subscription subscription)
        {
            if (IsPremium)
            {
                var notification = new Notification("Premium", "O aluno já tem um assinatur ativa");
                AddNotification(notification);
                return;
            }
            else
            {
                Subscriptions.Add(subscription);
            }
        }
    }
}