namespace API.Notifications
{
    public interface INotification
    {
        void Add(string error);

        string Get();
    }
}
