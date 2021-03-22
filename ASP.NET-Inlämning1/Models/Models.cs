﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Inlämning1.Models
{
    public class Attendee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone_Number { get; set; }
    }
    public class Event
    {
        public int ID { get; set; }
        public int Organizer_ID { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public int /*DateTime*/ Date { get; set; }
        public int Spots_Available { get; set; }
    }
    public class Organizer
    {
        public int ID { get; set; }
        public string Name { get; set; } 
        public string Email { get; set; }
        public int Phone_Number { get; set; }
    }
}
