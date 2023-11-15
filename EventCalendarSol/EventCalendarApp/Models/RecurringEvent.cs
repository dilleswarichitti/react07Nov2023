using System.ComponentModel.DataAnnotations.Schema;

namespace EventCalendarApp.Models
{
    public class RecurringEvent
    {
        public int Id { get; set; }
        public string RecurrencePattern{get;set; }
        public int EventId { get; set; }
        [ForeignKey("EventId")]
        public Event Event { get; set; }
    }
}
