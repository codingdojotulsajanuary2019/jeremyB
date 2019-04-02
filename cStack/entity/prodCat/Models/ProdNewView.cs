using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace prodCat.Models
{
    public class ProdNewView
    {
    public Product newProduct {get;set;}
    public List<Product> prodList {get;set;}
    }
}