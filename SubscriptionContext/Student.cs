using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ProjetoOOP.NotificationContext;
using ProjetoOOP.SharedContext;

namespace ProjetoOOP.SubscriptionContext
{
    public class Student : BaseContent
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(x => x.IsInactive);

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Subscription", "O aluno já é premium."));
                return;
            }

            Subscriptions.Add(subscription);
        }
    }
}