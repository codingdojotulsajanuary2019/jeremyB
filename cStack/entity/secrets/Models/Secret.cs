using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace secrets.Models
{
    public class Secret
    {
        [Key]
        public int secretId {get;set;}
        [Required]
        [MinLength(2, ErrorMessage = "Secret must be 2 characters or longer!")]
        [Display(Name="Secret:")]
        public string content {get;set;}
        public User creator {get;set;}
        public DateTime created_at {get;set;} = DateTime.Now;
        public List<Like> likes {get;set;}
    }
}