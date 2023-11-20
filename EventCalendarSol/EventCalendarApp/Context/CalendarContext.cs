using EventCalendarApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EventCalendarApp.Context
{

    public class CalendarContext : DbContext
    {
        public CalendarContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<RecurringEvent> RecurringEvents { get; set; }
        //public DbSet<Reminder> Reminders { get; set; }
        //public DbSet<Notification> Notifications { get; set; }
        public DbSet<SharingEvent> SharingEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // relationship between Event and Category
            modelBuilder.Entity<Event>()
                .HasOne<Category>(e => e.Category)
                .WithMany(c => c.Events)
                .HasForeignKey(e => e.CategoryId);

            //// relationship between Event and reminder
            //modelBuilder.Entity<Event>()
            //    .HasOne(e => e.Reminder)
            //    .WithOne(r => r.Event) 
            //    .HasForeignKey<Reminder>(r => r.EventId);

        }
    }
}