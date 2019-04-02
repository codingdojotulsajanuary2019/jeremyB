using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace activityPlanner.Models
{
    public class Participant
    {
        [Key]
        public int participantId {get;set;}
        public int userId {get;set;}
        public int eventId {get;set;}
        public User theUser {get;set;}
        public Event theEvent {get;set;}
    }
}