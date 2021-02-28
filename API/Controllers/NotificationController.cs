
using API.Notifications;

using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly INotification _notification;

        public NotificationController(INotification notification)
        {
            _notification = notification;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            _notification.Add("Error");

            return BadRequest(_notification.Get());
        }
    }
}
