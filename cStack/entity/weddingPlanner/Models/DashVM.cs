using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace weddingPlanner.Models
{
    public class DashVM
    {
        public User creator {get;set;}
        
        public List<Wedding> weddingList {get;set;}
    }

}