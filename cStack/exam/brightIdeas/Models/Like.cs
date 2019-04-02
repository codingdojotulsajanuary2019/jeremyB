using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace brightIdeas.Models
{
    public class Like
    {
        [Key]
        public int likeId {get;set;}
        public int userId {get;set;}
        public int ideaId {get;set;}
        public User theUser {get;set;}
        public Idea theIdea {get;set;}
    }
}