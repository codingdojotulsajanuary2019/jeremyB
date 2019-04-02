using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace prodCat.Models
{
    public class CatNewView
    {
    public Category newCategory {get;set;}
    public List<Category> catList {get;set;}
    }
}