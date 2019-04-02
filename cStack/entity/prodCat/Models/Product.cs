using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace prodCat.Models
{
    public class Product
    {
        [Key]
        public int productId {get;set;}


        [Required(ErrorMessage = "Name is required")]
        [Display(Name="Name")]
        [MinLength(2, ErrorMessage = "Name must be 2 characters or longer!")]
        public string name {get;set;}

        [Required(ErrorMessage = "Description is required")]
        [Display(Name="Description")]
        [MinLength(8, ErrorMessage = "Description must be 8 characters or longer!")]
        public string desc {get;set;}

        [Required(ErrorMessage = "Price is required")]
        [Display(Name="Price")]
        public decimal price {get;set;}
        
        public List<Association> prodCategories {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}