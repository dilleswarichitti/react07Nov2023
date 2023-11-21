using System.ComponentModel.DataAnnotations.Schema;

namespace EventCalendarApp.Models
{
    public class Category
    {
        public int id { get; set; }//identity GUID
        public string name { get; set; }//which type of category
        public string color { get; set; }//color of the category
        public List<Event>? Events { get; set; }//list of events
    }
}