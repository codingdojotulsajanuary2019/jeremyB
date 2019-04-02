using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace secrets.Models
{
    public class SecVM
    {
        public User thisUser {get;set;}
        public Secret newSec {get;set;}
        public List<Secret> allSec {get;set;}
    }

}