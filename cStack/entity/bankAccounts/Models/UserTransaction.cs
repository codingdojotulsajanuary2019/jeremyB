using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace bankAccounts.Models
{
    public class UserTransaction
    {
        public User loggedUser {get;set;}
        public Transaction newTrans {get;set;}

    }
}