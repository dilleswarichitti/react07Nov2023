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
    }
}