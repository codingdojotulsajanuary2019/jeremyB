using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace activityPlanner.Models
{
    public class ActVM
    {
        public User thisUser {get;set;}
        public Event thisEvent {get;set;}
    }
}