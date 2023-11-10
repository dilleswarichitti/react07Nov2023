using EventCalendarApp.Exceptions;
using EventCalendarApp.Interface;
using EventCalendarApp.Models;
using Microsoft.Extensions.Logging;

namespace EventCalendarApp.Services
{
    public class EventService : IEventService
    {
        private readonly IRepository<int, Event> _eventRepository;

        public EventService(IRepository<int, Event> repository)
        {
            _eventRepository = repository;
        }
        public Event Add(Event events)
        {
              var result = _eventRepository.Add(events);
              return result;
        }
        public List<Event> GetEvents()
        {
            var events = _eventRepository.GetAll();
            if (events != null)
            {
                return events.ToList();
            }
            throw new NoEventsAvailableException();
        }

        public Event Remove(Event events)
        {
            var EventId = _eventRepository.GetAll().FirstOrDefault(e => e.Id == events.Id);
            if (EventId != null)
            {
                var result = _eventRepository.Delete(EventId.Id);
                if (result != null) return result;
            }
            return EventId;
        }

        /*public Event Update(Event events)
        {
            var EventId = _eventRepository.GetAll().FirstOrDefault(e => e.Id == events.Id);
            if (EventId != null)
            {
                var result = _eventRepository.Update(events);
                if (result != null) return result;
            }
            return EventId;
        }*/
    }
}
