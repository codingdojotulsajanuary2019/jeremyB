using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace cruDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public string Chef {get;set;}
        [Required]
        [Range(1,6)]
        public int Tastiness{get;set;}
        [Required]
        [Range(0,10000)]
        public int Calories {get;set;}
        [Required]
        public string Description {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now; 
    }

    public class alldishes
    {
        public List<Dish> allDishes {get;set;}
    }

}