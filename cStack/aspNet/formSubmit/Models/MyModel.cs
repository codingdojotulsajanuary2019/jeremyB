using System;
using System.ComponentModel.DataAnnotations;

namespace formSubmit.Models
{
    public class User
    {
        [Required]
        [MinLength(4, ErrorMessage="Needs to be longer")]
        public string fname {get;set;}

        [Required]
        [MinLength(4, ErrorMessage="Needs to be longer")]
        public string lname {get;set;}

        [Required]
        [Range(0,200, ErrorMessage="Cannot be negative or above 200.")]
        public int age {get;set;}

        [Required]
        [EmailAddress]
        public string email {get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string password {get;set;}

    }
}