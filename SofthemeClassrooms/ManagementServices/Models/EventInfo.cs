﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementServices.Models
{
    public class EventInfo
    {
        public long Id { get; set; }
        public bool AllowSubscription { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string OrganizerName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ApplicationUserID { get; set; }
        public bool IsPublic { get; set; }
        public int RoomId { get; set; }
    }
}
