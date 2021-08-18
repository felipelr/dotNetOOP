using System;
using ProjetoOOP.NotificationContext;

namespace ProjetoOOP.SharedContext
{
    public abstract class BaseContent : Notifiable
    {
        protected BaseContent()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}