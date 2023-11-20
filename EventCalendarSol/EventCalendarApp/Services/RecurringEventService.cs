using EventCalendarApp.Interface;
using EventCalendarApp.Models;

namespace EventCalendarApp.Services
{
    public class RecurringEventService : IRecurringEventService
    {
        private readonly IRepository<int, Event> _eventRepository;
        private readonly IRepository<int, RecurringEvent> _recurringeventRepository;
        public RecurringEventService(IRepository<int, Event> eventRepository , IRepository<int, RecurringEvent> recurringeventRepository)
        {
            _eventRepository = eventRepository;
            _recurringeventRepository = recurringeventRepository;
        }
        public Event Create(Event recurringEvent, int numberOfOccurrences)
        {
            if ((bool)recurringEvent.IsRecurring) 
            {
                ImplementRecurringPattern(recurringEvent, numberOfOccurrences);
            }
            var result = _eventRepository.Add(recurringEvent);
            return result;
        }
        private void ImplementRecurringPattern(Event recurringEvent, int numberOfOccurrences)
        {
            var recurringEventEntity = new RecurringEvent
            {
                PatternType = recurringEvent.RecurringEvent.PatternType,
            };
            // Generate occurrences based on the recurring pattern
            IEnumerable<Event> occurrences;
            switch (recurringEvent.RecurringEvent.PatternType)
            {
                case RecurringPatternType.EveryDay:
                    occurrences = GenerateDailyOccurrences(recurringEvent, recurringEventEntity, numberOfOccurrences);
                    break;
                case RecurringPatternType.EveryWeek:
                    occurrences = GenerateWeeklyOccurrences(recurringEvent, recurringEventEntity, numberOfOccurrences);
                    break;
                case RecurringPatternType.EveryMonth:
                    occurrences = GenerateMonthlyOccurrences(recurringEvent, recurringEventEntity, numberOfOccurrences);
                    break;
                case RecurringPatternType.EveryYear:
                    occurrences = GenerateYearlyOccurrences(recurringEvent, recurringEventEntity, numberOfOccurrences);
                    break;
                default:
                    throw new ArgumentException("Invalid recurring pattern type");
            }
        }
            // Generate occurrences for a daily recurring event
        private IEnumerable<Event> GenerateDailyOccurrences(Event recurringEvent,RecurringEvent recurringEventEntity, int numberOfOccurrences)
        {
            var occurrences = new List<Event>();

            for (int i = 0; i < numberOfOccurrences; i++)
            {
                var occurrence = new Event
                {
                    Title = recurringEvent.Title,
                    StartTime = recurringEvent.StartTime.AddDays(i),
                    EndTime = recurringEvent.EndTime.AddDays(i),
                    Startdate = recurringEvent.Startdate.AddDays(i),
                    Enddate = recurringEvent.Enddate.AddDays(i),
                    IsRecurring = false,  // Occurrences are not recurring
                    RecurringEvent = recurringEventEntity  // No specific pattern for occurrences
                };

               occurrences.Add(occurrence);
            }

            return occurrences;
        }

        // Generate occurrences for a weekly recurring event
        private IEnumerable<Event> GenerateWeeklyOccurrences(Event recurringEvent, RecurringEvent recurringEventEntity, int numberOfOccurrences)
        {
            var occurrences = new List<Event>();

            for (int i = 0; i < numberOfOccurrences; i++)
            {
                var occurrence = new Event
                {
                    Title = recurringEvent.Title,
                    StartTime = recurringEvent.StartTime.AddDays(7 * i),
                    EndTime = recurringEvent.EndTime.AddDays(7 * i),
                    Startdate = recurringEvent.Startdate.AddDays(7 * i),
                    Enddate = recurringEvent.Enddate.AddDays(7 * i),
                    IsRecurring = false,  // Occurrences are not recurring
                    RecurringEvent = recurringEventEntity  // No specific pattern for occurrences
                };

                occurrences.Add(occurrence);
            }

            return occurrences;
        }

        // Generate occurrences for a monthly recurring event
        private IEnumerable<Event> GenerateMonthlyOccurrences(Event recurringEvent, RecurringEvent recurringEventEntity, int numberOfOccurrences)
        {
            var occurrences = new List<Event>();

            for (int i = 0; i < numberOfOccurrences; i++)
            {
                var occurrence = new Event
                {
                    Title = recurringEvent.Title,
                    StartTime = recurringEvent.StartTime.AddMonths(i),
                    EndTime = recurringEvent.EndTime.AddMonths(i),
                    Startdate = recurringEvent.Startdate.AddMonths(i),
                    Enddate = recurringEvent.Enddate.AddMonths(i),
                    IsRecurring = false,  // Occurrences are not recurring
                    RecurringEvent = recurringEventEntity  // No specific pattern for occurrences
                };

                occurrences.Add(occurrence);
            }

            return occurrences;
        }

        // Generate occurrences for a yearly recurring event
        private IEnumerable<Event> GenerateYearlyOccurrences(Event recurringEvent, RecurringEvent recurringEventEntity, int numberOfOccurrences)
        {
            var occurrences = new List<Event>();

            for (int i = 0; i < numberOfOccurrences; i++)
            {
                var occurrence = new Event
                {
                    Title = recurringEvent.Title,
                    StartTime = recurringEvent.StartTime.AddYears(i),
                    EndTime = recurringEvent.EndTime.AddYears(i),
                    Startdate = recurringEvent.Startdate.AddYears(i),
                    Enddate = recurringEvent.Enddate.AddYears(i),
                    IsRecurring = false,  // Occurrences are not recurring
                    RecurringEvent = recurringEventEntity  // No specific pattern for occurrences
                };

                occurrences.Add(occurrence);
            }

            return occurrences;
        }

        public Event Remove(Event events)
        {
            throw new NotImplementedException();
        }

        public Event Update(Event events)
        {
            throw new NotImplementedException();
        }
    }
}
