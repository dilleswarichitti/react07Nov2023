﻿using EventCalendarApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EventCalendarApp.Context
{
    public class CalendarContext : DbContext
    {
        public CalendarContext(DbContextOptions options) : base(options)
        {
           
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
       // public DbSet<Category> Categories { get; set; }
        //public DbSet<Settings> Settings { get; set; }
    }
}
