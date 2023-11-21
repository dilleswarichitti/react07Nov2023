using EventCalendarApp.Models;

namespace EventCalendarApp.Interface
{
    public interface IRecurringEventService
    {
        Event Create(Event recurringEvent, int numberOfOccurrences);
        Event Remove(Event events);
        Event Update(Event events);
    }
}
