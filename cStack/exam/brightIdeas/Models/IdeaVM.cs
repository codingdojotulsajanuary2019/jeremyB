using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace brightIdeas.Models
{
    public class IdeaVM
    {
        public User thisUser {get;set;}
        public Idea newIdea {get;set;}
        public List<Idea> allIdea {get;set;}
    }
}