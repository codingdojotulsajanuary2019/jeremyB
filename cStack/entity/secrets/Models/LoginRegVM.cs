using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace secrets.Models
{
    public class LoginRegVM
    {
        public User newUser {get;set;}
        public LoginUser logUser {get;set;}
    }

}