using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace chefDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}
        
        [Required]
        [MinLength(4, ErrorMessage = "Dish name must be 4 characters or longer!")]
        [Display(Name="Dish Name:")]
        public string DishName {get;set;}
        public Chef creator {get;set;}
        
        [Required]
        [Range(1,6)]
        [Display(Name="Tastiness:")]
        public int taste {get;set;}
        
        [Range(0,10000)]
        [Display(Name="Calories:")]
        public int cal {get;set;}
        
        [Required]
        [MinLength(8, ErrorMessage = "Description must be 8 characters or longer!")]
        public string Description {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        
        [Required]
        [Display(Name="Chef:")]
        public int? ChefId {get;set;}
    }

    public class allDish
    {
        public List<Dish> dishList {get;set;}
    }

}