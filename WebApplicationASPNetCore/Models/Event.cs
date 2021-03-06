using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationASPNetCore.Models
{
    public class Event
    {
        public int Id { get; set; } // PK
        public string Title { get; set; }
        public Organizer OrganzierId { get; set; }virtual // FK
        public string Description { get; set; }
        public string Place { get; set; }
        public string Address { get; set; }
        public int Date { get; set; }
        public int SpotsAvailable { get; set; }
        public ICollection<AttendeeEvent> AttendeeEvents { get; set; }

        public Event()
        {

        }
    }
}
