using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace brightIdeas.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required(ErrorMessage = "Name is required")]
        [MinLength(2, ErrorMessage = "Name must be 2 characters or longer!")]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage="Name can only contain letters and spaces.")]

        public string Name {get;set;}

        [Required(ErrorMessage = "Alias is required")]
        [MinLength(2, ErrorMessage = "Alias must be 2 characters or longer!")]
        [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage="Alias can only be alphanumeric.")]
        public string Alias {get;set;}

        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        public string Password {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
        public List<Like> likes {get;set;}
        public List<Idea> created {get;set;}
    
        public override string ToString()
        {
            Console.WriteLine("---------------------------------------");
            return $"User object: {Name}";
        }

    }
    public class LoginUser
    {
        [Required]
        public string Email {get;set;}
        [Required]
        [DataType(DataType.Password)]
        public string Password {get;set;}
    }
}