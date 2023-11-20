using System.ComponentModel.DataAnnotations.Schema;

namespace EventCalendarApp.Models
{
    public class Event
    {
        public int Id { get; set; } //identity-GUID
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Location { get; set; }
        public bool? IsRecurring { get; set; }
        public RecurringEvent? RecurringEvent { get; set; } 
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
        public List<SharingEvent>? SharingEvents { get; set;}
        //public int RemainderId { get; set; }
        //[ForeignKey("RemainderId")]
        //public Reminder? Reminder { get; set; }

    }
}