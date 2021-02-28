using System.Collections.Generic;

namespace API.Notifications
{
    public class Notification : INotification
    {
        private readonly List<string> _notifications = new List<string>();

        public void Add(string error)
        {
            _notifications.Add(error);
        }

        public string Get()
        {
            return string.Join(',', _notifications);
        }
    }
}
