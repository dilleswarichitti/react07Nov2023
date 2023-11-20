using EventCalendarApp.Models;
using EventCalendarApp.Repositories;

namespace EventCalendarApp.Interface
{
    public interface ISharingEventService
    {
        public IList<SharingEvent> GetAll();
        public SharingEvent GetById(int id);
        public SharingEvent Add(SharingEvent sharingEvent);
        public SharingEvent Update(SharingEvent sharingEvent);
        public SharingEvent Remove(int id);

    }
}
