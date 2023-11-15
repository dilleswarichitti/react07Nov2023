using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventCalendarApp.Models
{
    public class SharingEvent
    {
        [Key]
        public int Id { get; set; }//identity GUID
        public string SharedWithUserId { get; set; }
        // Foreign Key for Event
        public int EventId { get; set; }
        [ForeignKey("EventId")]
        public Event Event { get; set; }
    }
}
