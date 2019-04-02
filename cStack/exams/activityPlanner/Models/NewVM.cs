using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace activityPlanner.Models
{
    public class NewVM
    {
        public User thisUser {get;set;}
        public Event newEvent {get;set;}
    }
}