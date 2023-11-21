using EventCalendarApp.Exceptions;
using EventCalendarApp.Interface;
using EventCalendarApp.Models;
using EventCalendarApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventCalendarApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecurringEventController : ControllerBase
    {
        private readonly IRecurringEventService _recurringEventService;

        public RecurringEventController(IRecurringEventService recurringEventService)
        {
            _recurringEventService = recurringEventService;
        }
        [Authorize(Roles = "organizer")]
        [HttpPost]
        public ActionResult Create(Event recurringEvent, int numberOfOccurrences)
        {
            string errorMessage = string.Empty;
            try
            {
                var result = _recurringEventService.Create(recurringEvent, numberOfOccurrences);
                return Ok(result);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
            return BadRequest(errorMessage);
        }
    }
}
