using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace chefDishes.Models
{
    public class AllModels
    {
        public List<Chef> allChefs {get;set;}
        public Dish newDish {get;set;}
    }
}