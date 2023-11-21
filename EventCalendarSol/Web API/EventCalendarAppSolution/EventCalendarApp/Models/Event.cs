using System.ComponentModel.DataAnnotations.Schema;

namespace EventCalendarApp.Models
{
    public class Event
    {
        public int Id { get; set; } //identity-GUID
        public string Title { get; set; }//give title for an event
        public string? Description { get; set; }//give information about event
        public DateTime Startdate { get; set; }//on which date the event is occurring
        public DateTime Enddate { get; set; }//end date for an event 
        public DateTime StartTime { get; set; }//start time of an event
        public DateTime EndTime { get; set; }//end time of an event
        public string? Location { get; set; }//location of an event
        public bool? IsRecurring { get; set; }//is the event is repeating or not
        public RecurrencePattern? PatternType { get; set; }//if event is repeating which type of pattern
        public int CategoryId { get; set; }//Foreign Key of Category
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; } 
        public List<SharingEvent>? SharingEvents { get; set; }
        public enum RecurrencePattern
        {
            EveryDay,
            EveryWeek,
            EveryMonth,
            EveryYear
        }
    }
}
