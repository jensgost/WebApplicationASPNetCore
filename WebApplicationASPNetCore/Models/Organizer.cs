using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationASPNetCore.Models
{
    public class Organizer
    {
        public int Id { get; set; } // PK
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Event> Events { get; set; }

        public Organizer()
        {

        }
    }
}
