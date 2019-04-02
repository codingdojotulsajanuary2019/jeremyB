using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace prodCat.Models
{
    public class CatInfoView
    {
        public Category thisCategory {get;set;}
        public List<Product> prodList {get;set;}
        public Association newPair {get;set;}
    }
}