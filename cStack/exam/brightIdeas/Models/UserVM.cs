using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace brightIdeas.Models
{
    public class UserVM
    {
        public User thisUser {get;set;}
        public List<Like> userLikes {get;set;}
    }
}