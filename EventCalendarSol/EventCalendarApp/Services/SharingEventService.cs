using EventCalendarApp.Interface;
using EventCalendarApp.Models;
using EventCalendarApp.Repositories;

namespace EventCalendarApp.Services
{
    public class SharingEventService : ISharingEventService
    {
        private readonly SharingEventRepository _sharingEventRepository;

        public SharingEventService(SharingEventRepository sharingEventRepository)
        {
            _sharingEventRepository = sharingEventRepository;
        }

        public IList<SharingEvent> GetAll() 
        {
            return _sharingEventRepository.GetAll();
        }

        public SharingEvent GetById(int id)
        {
            return _sharingEventRepository.GetById(id);
        } 

        public SharingEvent Add(SharingEvent sharingEvent) 
        {
            _sharingEventRepository.Add(sharingEvent);
            return sharingEvent;
        }

        public SharingEvent Update(SharingEvent sharingEvent)
        {
            _sharingEventRepository.Update(sharingEvent);
            return sharingEvent;
        }

        public SharingEvent Remove(int id)
        {
            _sharingEventRepository.Delete(id);
            return null;
        }
    }
}
