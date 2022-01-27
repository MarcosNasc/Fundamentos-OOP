using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Plan : Entity
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}