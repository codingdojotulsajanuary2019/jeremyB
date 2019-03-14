using System;
using System.Collections.Generic;

namespace dojoDachi.Models
{
    public class Dachi
    {
       public int full {get;set;}
       public int happy {get;set;}
       public int energy {get;set;}
       public int meal {get;set;}

       public Dachi()
       {
           full = 20;
           happy = 20;
           energy = 50;
           meal = 3;
       }
    }
}