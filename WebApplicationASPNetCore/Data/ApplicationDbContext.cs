using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationASPNetCore.Models;

namespace WebApplicationASPNetCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebApplicationASPNetCore.Models.Event> Event { get; set; }
        public DbSet<WebApplicationASPNetCore.Models.Attendee> Attendee { get; set; }
        public DbSet<WebApplicationASPNetCore.Models.Organizer> Organizer { get; set; }
        public DbSet<WebApplicationASPNetCore.Models.AttendeeEvent> AttendeeEvent { get; set; }
    }
}
