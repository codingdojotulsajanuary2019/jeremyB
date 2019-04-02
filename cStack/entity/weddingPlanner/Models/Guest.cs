using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace weddingPlanner.Models
{
    public class Guest
    {
        [Key]
        public int guestId {get;set;}
        public int weddingId {get;set;}
        public int userId {get;set;}
        public Wedding wedding {get;set;}
        public User user {get;set;}
    }
}