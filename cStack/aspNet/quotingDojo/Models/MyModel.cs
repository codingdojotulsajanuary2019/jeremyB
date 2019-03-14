using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace quotingDojo.Models
{
    public class Quote
    {
        [Required]
        [MinLength(2, ErrorMessage="Name must be 2 letters or more")]
        public string name {get;set;}

        [Required]
        [MinLength(10, ErrorMessage="Quote must be 10 or more characters")]
        public string content {get;set;}
    }
}