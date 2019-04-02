using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace brightIdeas.Models
{
    public class Idea
    {
        [Key]
        public int ideaId {get;set;}
        [Required]
        [MinLength(5, ErrorMessage = "Secret must be 5 characters or longer!")]
        [Display(Name="Secret:")]
        public string content {get;set;}
        public User creator {get;set;}
        public DateTime created_at {get;set;} = DateTime.Now;
        public List<Like> likes {get;set;}
        
        public override string ToString()
        {
            Console.WriteLine("---------------------------------------");
            return $"Idea object: {content}";
        }
    }

}