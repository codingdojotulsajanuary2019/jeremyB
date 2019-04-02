using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace secrets.Models
{
    public class Like
    {
        [Key]
        public int likeId {get;set;}
        public int userId {get;set;}
        public int secretId {get;set;}
        public User user {get;set;}
        public Secret secret {get;set;}
    }
}