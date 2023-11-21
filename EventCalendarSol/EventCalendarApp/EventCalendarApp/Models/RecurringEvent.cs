using System.ComponentModel.DataAnnotations.Schema;

namespace EventCalendarApp.Models
{
    public class RecurringEvent
    {
        public int Id { get; set; }//identity GUID
        public RecurringPatternType PatternType { get; set; }
        public int EventId { get; set; }
        [ForeignKey("EventId")]
        public Event? Event { get; set;}
    }
    public enum RecurringPatternType
    {
        None,
        EveryDay,
        EveryWeek,
        EveryMonth,
        EveryYear
    }
}
