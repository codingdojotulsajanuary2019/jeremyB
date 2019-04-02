using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace prodCat.Models
{
    public class Category
    {
        [Key]
        public int categoryId {get;set;}

        [Required(ErrorMessage = "Name is required")]
        [Display(Name="Name")]
        [MinLength(2, ErrorMessage = "Name must be 2 characters or longer!")]
        public string name {get;set;}
        
        public List<Association> catProducts {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}