using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventCalendarApp.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime? RemainderDateTime { get; set; }
        public string NotificationType {get; set;}
        // Foreign Key for Event
        public int EventId { get; set; }
        [ForeignKey("EventId")]
        public Event? Events { get; set; } 
    }
}
