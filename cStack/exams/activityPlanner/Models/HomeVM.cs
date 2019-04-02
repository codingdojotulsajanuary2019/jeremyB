using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace activityPlanner.Models
{
    public class HomeVM
    {
        public User thisUser {get;set;}
        public List<Event> allEvent {get;set;}
    }
}