using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace prodCat.Models
{
    public class ProdInfoView
    {
        public Product thisProduct {get;set;}
        public List<Category> catList {get;set;}
        public Association newPair {get;set;}
    }
}