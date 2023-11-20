using EventCalendarApp.Context;
using EventCalendarApp.Interface;
using EventCalendarApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EventCalendarApp.Repositories
{
    public class RecurringEventRepository : IRepository<int, RecurringEvent>
    {
        private readonly CalendarContext _context;

        public RecurringEventRepository(CalendarContext context)
        { 
            _context = context;
        }
        public RecurringEvent Add(RecurringEvent entity)
        {
            _context.RecurringEvents.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public RecurringEvent Delete(int key)
        {
            var recurringevent = GetById(key);
            if (recurringevent != null)
            {
                _context.RecurringEvents.Remove(recurringevent);
                _context.SaveChanges();
                return recurringevent;
            }
            return null;
        }

        public IList<RecurringEvent> GetAll()
        {
            if (_context.RecurringEvents.Count() == 0)
                return null;
            return _context.RecurringEvents.ToList();
        }

        public RecurringEvent GetById(int key)
        {
            var recurringevent = _context.RecurringEvents.SingleOrDefault(re => re.Id == key);
            return recurringevent;
        }

        public RecurringEvent Update(RecurringEvent entity)
        {
            var recurringevent = GetById(entity.Id);
            if (recurringevent != null)
            {
                _context.Entry<RecurringEvent>(recurringevent).State = EntityState.Modified;
                _context.SaveChanges();
                return recurringevent;
            }
            return null;
        }
    }
}
