using EventCalendarApp.Exceptions;
using EventCalendarApp.Interface;
using EventCalendarApp.Models;
using EventCalendarApp.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventCalendarApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }
        [HttpGet]
        public ActionResult Get()
        {
            string errorMessage = string.Empty;
            try
            {
                var result = _eventService.GetEvents();
                return Ok(result);
            }
            catch (NoEventsAvailableException e)
            {
                errorMessage = e.Message;
            }
            return BadRequest(errorMessage);
        }
        [Authorize(Roles = "organizer")]
        [HttpPost]
        public ActionResult Create(Event events)
        {
            string errorMessage = string.Empty;
            try
            {
                var result = _eventService.Add(events);
                return Ok(result);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
            return BadRequest(errorMessage);
        }
       /*[HttpPut]
        public ActionResult Update(Event events)
        {
            string errorMessage = string.Empty;
            try
            {
                var result = _eventService.Update(events);
                return Ok(events);
            }
            catch (EventsCantUpdateException e)
            {
                errorMessage = e.Message;
            }
            return BadRequest(errorMessage);
        }*/

        [HttpDelete]
        public ActionResult Remove(Event events)
        {
            string errorMessage = string.Empty;
            try
            {
                var result = _eventService.Remove(events);
                return Ok(events);
            }
            catch(EventsCantRemoveException e) 
            {
                errorMessage = e.Message;
            }
            return BadRequest(errorMessage);
        }
    }
}
