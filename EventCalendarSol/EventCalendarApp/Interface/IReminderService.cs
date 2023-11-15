using EventCalendarApp.Models;

namespace EventCalendarApp.Interface
{
    public interface IReminderService
    {
        List<Reminder> GetReminders();
        Reminder Add(Reminder reminders); 
        //Reminder Remove(Reminder reminders);
        //Reminder Update(Reminder reminders);
    }
}
