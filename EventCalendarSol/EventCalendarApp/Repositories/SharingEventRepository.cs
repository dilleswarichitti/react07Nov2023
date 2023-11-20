using EventCalendarApp.Context;
using EventCalendarApp.Interface;
using EventCalendarApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EventCalendarApp.Repositories
{
    public class SharingEventRepository : IRepository<int, SharingEvent>
    {
        private readonly CalendarContext _context;

        public SharingEventRepository(CalendarContext context)
        {
            _context = context;
        }
        public SharingEvent GetById(int key)
        {
            return _context.SharingEvents.Include(se => se.Event).FirstOrDefault(se => se.Id == key);
        }
        public IList<SharingEvent> GetAll()
        {
            return _context.SharingEvents.Include(se => se.Event).ToList();
        }

        public SharingEvent Add(SharingEvent entity)
        {

            _context.SharingEvents.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public SharingEvent Update(SharingEvent entity)
        {
            var sharingEvent = GetById(entity.Id);
            if (sharingEvent != null)
            {
                _context.Entry<SharingEvent>(sharingEvent).State = EntityState.Modified;
                _context.SaveChanges();
                return sharingEvent;
            }
            return null;

        }

        public SharingEvent Delete(int key)
        {
            var sharingEvent = GetById(key);
            if (sharingEvent != null)
            {
                _context.SharingEvents.Remove(sharingEvent);
                _context.SaveChanges();
                return sharingEvent;
            }
            return null;
        }
    }
}