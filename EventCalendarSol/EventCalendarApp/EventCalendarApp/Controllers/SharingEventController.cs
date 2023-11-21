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
    public class SharingEventController : ControllerBase
    {
        private readonly ISharingEventService _sharingEventService;

        public SharingEventController(ISharingEventService sharingEventService)
        {
            _sharingEventService = sharingEventService;
        }
        [HttpGet]
        public ActionResult Get()
        {
            string errorMessage = string.Empty;
            try
            {
                var result = _sharingEventService.GetAll();
                return Ok(result);
            }
            catch (NocategoriesAvailableException e)
            {
                errorMessage = e.Message;
            }
            return BadRequest(errorMessage);
        }
        [Authorize(Roles = "organizer")]
        [HttpPost]
        public ActionResult Create(SharingEvent SharingEvent)
        {
            string errorMessage = string.Empty;
            try
            {
                var result = _sharingEventService.Add(SharingEvent);
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
