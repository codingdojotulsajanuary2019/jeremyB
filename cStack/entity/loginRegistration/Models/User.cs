using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace loginRegistration.Models
{
    public class User
    {
        [Key]
        public int Id {get;set;}
        [Required]
        [MinLength(2, ErrorMessage = "First name must be 2 characters or longer!")]
        public string fName {get;set;}
        [Required]
        [MinLength(2, ErrorMessage = "Last name must be 2 characters or longer!")]
        public string lName {get;set;}
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
    }
}