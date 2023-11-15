using System.ComponentModel.DataAnnotations.Schema;

namespace EventCalendarApp.Models
{
    public class Remainder
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime RemainderDateTime { get; set; }
        public string NotificationType { get; set; }
        // Foreign Key for Event
        public int EventId { get; set; }
        [ForeignKey("EventId")]
        public Event Event { get; set; }
    }
}
