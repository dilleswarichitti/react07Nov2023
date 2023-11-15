using System.ComponentModel.DataAnnotations.Schema;

namespace EventCalendarApp.Models
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public int EventId { get; set; }
        [ForeignKey("EventId")]
        public Event Event { get; set; }
    }
}