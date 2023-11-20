using System.ComponentModel.DataAnnotations.Schema;

namespace EventCalendarApp.Models
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public List<Event>? Events { get; set; }
    }
}