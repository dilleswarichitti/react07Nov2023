using EventCalendarApp.Context;
using EventCalendarApp.Interface;
using EventCalendarApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EventCalendarApp.Repositories
{
    public class ReminderRepository : IRepository<int, Reminder>
    {
        private readonly CalendarContext _context;

        public ReminderRepository(CalendarContext context)
        {
            _context = context;
        }

        public Reminder Add(Reminder entity)
        {
            _context.Reminders.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Reminder Delete(int key)
        {
            var remainder = GetById(key);
            if (remainder != null)
            {
                _context.Reminders.Remove(remainder);
                _context.SaveChanges();
                return remainder;
            }
            return null;
        }

        public IList<Reminder> GetAll()
        {
            if (_context.Reminders.Count() == 0)
                return null;
            return _context.Reminders.ToList();
        }

        public Reminder GetById(int key)
        {
            var remainder = _context.Reminders.SingleOrDefault(r => r.Id == key);
            return remainder;
        }

        public Reminder Update(Reminder entity)
        {
            var remainder = GetById(entity.Id);
            if (remainder != null)
            {
                _context.Entry<Reminder>(remainder).State = EntityState.Modified;
                _context.SaveChanges();
                return remainder;
            }
            return null;
        }
    }
}