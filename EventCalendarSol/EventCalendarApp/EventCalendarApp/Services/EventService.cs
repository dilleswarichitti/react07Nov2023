using EventCalendarApp.Exceptions;
using EventCalendarApp.Interface;
using EventCalendarApp.Models;

namespace EventCalendarApp.Services
{
    public class EventService : IEventService
    {
        private readonly IRepository<int, Event> _eventRepository;
        //private readonly IRepository<int, SharingEvent> _sharingEventRepository;
        private readonly IRepository<int, Reminder> _reminderRepository;
        private readonly IRepository<int, Notification> _notificationRepository;
        // private readonly ICurrentUserService _currentUserService;
        public EventService(IRepository<int, Event> eventRepository, IRepository<int, Reminder> reminderRepository, IRepository<int, Notification> notificationRepository)
        {
            _eventRepository = eventRepository;
            _reminderRepository = reminderRepository;
            _notificationRepository = notificationRepository;
            //_currentUserService = currentUserService;
            //_sharingEventRepository = sharingEventRepository;
        }
        //public Event Create(Event events)
        //{
        //    var result = _eventRepository.Add(events);
        //    return result;
        //}
        //public void ShareEvent(int eventId, string sharedWithUserId)
        //{
        //    // Check if the event exists
        //    var existingEvent = _eventRepository.GetById(eventId);

        //    if (existingEvent == null)
        //    {
        //        // Handle the case where the event does not exist
        //        throw new ArgumentException("Event not found.");
        //    }

        //    // Check if the event is already shared with the user
        //    var existingSharingEvent = _sharingEventRepository.GetAll()
        //        .SingleOrDefault(se => se.EventId == eventId && se.SharedWithUserId == sharedWithUserId);

        //    if (existingSharingEvent != null)
        //    {
        //        // Handle the case where the event is already shared with the user
        //        throw new InvalidOperationException("Event is already shared with the user.");
        //    }

        //    // Create a new SharingEvent
        //    var sharingEvent = new SharingEvent
        //    {
        //        SharedWithUserId = sharedWithUserId,
        //        EventId = eventId
        //    };

        //    // Add the SharingEvent to the repository
        //    _sharingEventRepository.Add(sharingEvent);
        //}
        public Event Create(Event events) 
        {
            //var currentUser = _currentUserService.GetCurrentUserInfo();
            // events.UserEmail = user.Email; // Associate the event with the user
            var addedEvent = _eventRepository.Add(events);

            // Add reminder
            var reminder = new Reminder
            {
                Message = "Your event is coming up!",
                ReminderDateTime = events.StartTime,
                EventId = addedEvent.Id,
                //UserEmail = user.Email

            };
            _reminderRepository.Add(reminder);

            // Add notification
            var notification = new Notification

            {
                Content = "Event Notification",
                NotificationDateTime = SetNotificationTimeLogic(events.StartTime), // Set your notification time logic
                EventId = addedEvent.Id,
                // ReminderId=reminder.Id
                //UserEmail = user.Email
            };
            _notificationRepository.Add(notification);

            return addedEvent;
        }
        private static DateTime SetNotificationTimeLogic(DateTime eventsStartDateTime) => eventsStartDateTime.AddMinutes(-30);

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
