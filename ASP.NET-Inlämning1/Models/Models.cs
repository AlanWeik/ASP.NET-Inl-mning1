using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Inlämning1.Models
{
    public class Attendee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone_Number { get; set; }
        public List<Attendee> Attendees { get; set; }
    }
    public class Event
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public int Spots_Available { get; set; }
        public List<Event> Events { get; set; }
    }
    public class Organizer
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Email { get; set; }
        public int Phone_Number { get; set; }
        public List<Organizer> Organizers { get; set; }
    }
}
