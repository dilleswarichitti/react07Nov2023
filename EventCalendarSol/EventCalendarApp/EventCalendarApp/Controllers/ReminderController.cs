//using EventCalendarApp.Exceptions;
//using EventCalendarApp.Interface;
//using EventCalendarApp.Models;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace EventCalendarApp.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ReminderController : ControllerBase
//    {
//        private readonly IReminderService _reminderService;

//        public ReminderController(IReminderService reminderService)
//        {
//            _reminderService = reminderService;
//        }
//        [HttpGet]
//        public ActionResult Get(string User_Email)
//        {
//            string errorMessage = string.Empty;
//            try
//            {
//                // Reminder userId = null;
//                var result = _reminderService.GetRemindersByUser(User_Email);
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
//        public ActionResult Create(Reminder reminder)
//        {
//            string errorMessage = string.Empty;
//            try
//            {
//                var result = _reminderService.CreateReminder(reminder);
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