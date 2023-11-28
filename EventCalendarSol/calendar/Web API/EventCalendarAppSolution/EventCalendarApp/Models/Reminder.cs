using System.ComponentModel.DataAnnotations.Schema;
using EventCalendarApp.Models.DTOs;
namespace EventCalendarApp.Models
{
    public class Reminder
    {
        public int Id { get; set; }//identity GUID
        public string Message { get; set; }//Message that given to user while setting the reminder
        public DateTime? ReminderDateTime { get; set; }//on which date and time the reminder has to popup
        public int EventId { get; set; }//foreignkey of events

        [ForeignKey("EventId")]
        public Event? Event { get; set; }
    }
}