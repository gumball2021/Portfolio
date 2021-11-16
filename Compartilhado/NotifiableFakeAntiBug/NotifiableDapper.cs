using Dapper.Contrib.Extensions;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemCadastro.Compartilhado.NotifiableFakeAntiBug
{
   public class NotifiableDapper
    {
        protected NotifiableDapper() { }
        [Write(false)]
        public IReadOnlyCollection<Notification> Notifications { get; }
        [Write(false)]
        public bool Invalid { get; }
        [Write(false)]
        public bool Valid { get; }

        public void AddNotification(string property, string message) { }
        public void AddNotification(Notification notification) { }
        public void AddNotifications(IReadOnlyCollection<Notification> notifications) { }
        public void AddNotifications(IList<Notification> notifications) { }
        public void AddNotifications(ICollection<Notification> notifications) { }
        public void AddNotifications(Notifiable item) { }
        public void AddNotifications(params Notifiable[] items) { }
    }
}
