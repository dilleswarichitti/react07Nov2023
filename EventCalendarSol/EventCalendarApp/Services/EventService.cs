using EventCalendarApp.Exceptions;
using EventCalendarApp.Interface;
using EventCalendarApp.Models;
using static EventCalendarApp.Models.Event;

namespace EventCalendarApp.Services
{
    public class EventService : IEventService
    {
        private readonly IRepository<int, Event> _eventRepository;
        public EventService(IRepository<int, Event> repository)
        {
            _eventRepository = repository;
        }
        public Event Create(Event events)
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
        public Event Update(Event events)
        {
            var EventId = _eventRepository.GetAll().FirstOrDefault(e => e.Id == events.Id);
            if (EventId != null)
            {
                if (events == null)
                {
                    throw new ArgumentNullException("The provided event is null.");
                }
                // Validate start and end dates
                if (events.Startdate > events.Enddate)
                {
                    throw new ArgumentException("Start date cannot be after end date.");
                }
                // Validate start and end times
                if (events.StartTime > events.EndTime)
                {
                    throw new ArgumentException("Start time cannot be after end time.");
                }
                var result = _eventRepository.Update(events);
                if (result != null) return result;
            }
            return EventId;
        }
    }
}
