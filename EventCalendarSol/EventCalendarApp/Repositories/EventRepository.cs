using EventCalendarApp.Context;
using EventCalendarApp.Interface;
using EventCalendarApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EventCalendarApp.Repositories
{
    public class EventRepository : IRepository<int, Event>
    {
        private readonly CalendarContext _context;

        public EventRepository(CalendarContext context)
        {
            _context = context;
        }

        public Event Add(Event entity)
        {
            _context.Events.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Event Delete(int key)
        {
            var events = GetById(key);
            if (events != null)
            {
                _context.Events.Remove(events);
                _context.SaveChanges();
                return events; 
            }
            return null;
        }

        public IList<Event> GetAll()
        {
            if (_context.Events.Count() == 0)
                return null;
            return _context.Events.ToList();
        }

        public Event GetById(int key)
        {
            var events = _context.Events.SingleOrDefault(e => e.Id == key);
            return events;
        }

        public Event Update(Event entity)
        {
            var events = GetById(entity.Id);
            if (events != null)
            {
                _context.Entry<Event>(events).State = EntityState.Modified;
                _context.SaveChanges();
                return events;
            }
            return null;
        }
    }
}