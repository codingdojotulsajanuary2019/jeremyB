using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace weddingPlanner.Models
{
    public class ValidateDate: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Wedding wedding = (Wedding)validationContext.ObjectInstance;
            DateTime now = DateTime.Now;
            if (wedding.date > now)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Has to be in the future rapscallion.");
            }
        }
    }
    public class Wedding
    {
        [Key]
        public int weddingId {get;set;}
        
        [Required(ErrorMessage = "First wedder is required")]
        [MinLength(2, ErrorMessage = "First wedder must be 2 characters or longer!")]
        public string wedOne {get;set;}

        [Required(ErrorMessage = "Second wedder is required")]
        [MinLength(2, ErrorMessage = "Second wedder must be 2 characters or longer!")]
        public string wedTwo {get;set;}

        [Required]
        [ValidateDate]
        public DateTime date {get;set;}

        [Required]
        [MinLength(10, ErrorMessage = "Second wedder must be 10 characters or longer!")]
        public string address {get;set;}

        public User creator {get;set;}
        
        public List<Guest> guests {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        
    }

}