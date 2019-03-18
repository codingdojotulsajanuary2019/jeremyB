using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace chefDishes.Models
{
    public class ValidateAge: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Chef chef = (Chef)validationContext.ObjectInstance;
            DateTime then = DateTime.Today.AddYears(-18);
            if (chef.dob <= then)
            {
                return ValidationResult.Success;
            }
            else
            {
                if (chef.dob > DateTime.Today)
                {
                    return new ValidationResult("Date cannot be in the future you old rapscallion.");
                }
                return new ValidationResult("Chef must be greater than 18 years old. No kids allowed.");
            }
        }
    }
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}
        [Required]
        [Display(Name="First Name:")]
        [MinLength(4, ErrorMessage = "Chef first name must be 4 characters or longer!")]
        public string fName {get;set;}
        [Required]
        [Display(Name="Last Name:")]
        [MinLength(4, ErrorMessage = "Chef last name must be 4 characters or longer!")]
        public string lName {get;set;}
        [Required]
        [Display(Name="Date of Birth:")]
        [ValidateAge]
        public DateTime dob {get;set;}
        public List<Dish> Dishes {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }

    public class allChef
    {
        public List<Chef> chefList {get;set;}
    }
}