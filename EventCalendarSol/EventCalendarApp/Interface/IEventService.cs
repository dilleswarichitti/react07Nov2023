using EventCalendarApp.Models;

namespace EventCalendarApp.Interface
{
    public interface IEventService
    {
        List<Event> GetEvents(); 
        Event Create(Event events); 
        Event Remove(Event events);
        Event Update(Event events);
    }
}
