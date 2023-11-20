//using EventCalendarApp.Exceptions;
//using EventCalendarApp.Interfaces;
//using EventCalendarApp.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace EventCalendarApp.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class NotificationController : ControllerBase
//    {
//        private readonly INotificationService _notificationService;

//        public NotificationController(INotificationService notificationService)
//        {
//            _notificationService = notificationService;
//        }
//        [HttpGet]
//        public ActionResult Get(string User_Email)
//        {
//            string errorMessage = string.Empty;
//            try
//            {
//                // Reminder userId = null;
//                var result = _notificationService.GetNotificationsByUser(User_Email);
//                return Ok(result);
//            }
//            catch (RemaindersAreNotAvailableException e)
//            {
//                errorMessage = e.Message;
//            }
//            return BadRequest(errorMessage);
//        }
//        // [Authorize(Roles = "organizer")]
//        [HttpPost]
//        public ActionResult SendNotififcation(Notification notification)
//        {
//            string errorMessage = string.Empty;
//            try
//            {
//                var result = _notificationService.SendNotification(notification);
//                return Ok(result);
//            }
//            catch (Exception e)
//            {
//                errorMessage = e.Message;
//            }
//            return BadRequest(errorMessage);
//        }
//    }
//}