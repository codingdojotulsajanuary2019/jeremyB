using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace prodCat.Models
{
    public class Association
    {
        [Key]
        public int associationId {get;set;}

        public int productId {get;set;}
        public int categoryId {get;set;}

        public Product product {get;set;}
        public Category category {get;set;}

    }
}