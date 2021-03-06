using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Inlämning1.Models
{
    public class Organizer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone_Number { get; set; }
        public List<Event> Events { get; set; }
        public List<Attendee> Attendees { get; set; }
    }
}
