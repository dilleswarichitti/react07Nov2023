using System.ComponentModel.DataAnnotations.Schema;

namespace EventCalendarApp.Models
{
    public class Event
    {

        /// <summary>
        /// it is a model class for events
        /// </summary>
        public int Id { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
        public string StartDateTime { get; set; }
        public string NotificationDateTime { get; set; }
        public string? Location { get; set; }
        public bool? IsRecurring { get; set; }
        public string Recurring_frequency { get; set; }

        public int CategoryId { get; set; } = 0;
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        public string Email { get; set; }
        [ForeignKey("Email")]
        public User? User { get; set; }


    }

}