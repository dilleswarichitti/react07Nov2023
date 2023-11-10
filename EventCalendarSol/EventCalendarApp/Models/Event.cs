using System.ComponentModel.DataAnnotations.Schema;

namespace EventCalendarApp.Models
{
    public class Event
    {
        public int Id { get; set; } //identity-GUID
        public string Title { get; set; }
        public string ?Description { get; set; }
        public DateTime ?Startdate { get; set; }
        public DateTime ?Enddate { get; set; }
        public DateTime ?StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? Location { get; set; }
        //public List<int> CategoryIds { get; set; } 
        //public List<int> ReminderIds { get; set; } 
        //public bool IsRecurring { get; set; }
    }
}