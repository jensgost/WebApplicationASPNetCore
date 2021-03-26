using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationASPNetCore.Models
{
    public class AttendeeEvent
    {
        public int Id { get; set; }
        public Event Event { get; set; }
        public Attendee Attendee { get; set; }

    }
}
