using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace weddingPlanner.Models
{
 public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required(ErrorMessage = "First name is required")]
        [MinLength(2, ErrorMessage = "First name must be 2 characters or longer!")]
        public string fName {get;set;}

        [Required(ErrorMessage = "Last Name is required")]
        [MinLength(2, ErrorMessage = "Last name must be 2 characters or longer!")]
        public string lName {get;set;}

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
        public List<Guest> guests {get;set;}
        public List<Wedding> createdWed {get;set;}
    
        public override string ToString()
        {
            Console.WriteLine("---------------------------------------");
            return $"User: \n\tName: {fName} {lName}";
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