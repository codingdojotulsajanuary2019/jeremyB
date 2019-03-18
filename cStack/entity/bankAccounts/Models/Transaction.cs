using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace bankAccounts.Models
{
    public class Transaction
    {
        [Key]
        public int TransId {get;set;}

        [Required]
        [Display(Name="Deposit/Withdraw ")]
        public float Amount {get;set;}

        [Required]
        public int? UserId {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public override string ToString()
        {
            Console.WriteLine("---------------------------------------");
            return $"Transaction: \n\tAmount: {Amount}\n\tUserId: {UserId}";
        }
    }
}