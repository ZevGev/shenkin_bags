using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Turkiz.Model;

namespace Turkiz.Models
{
    public class Transaction
    {
        
        public int TransactionId { get; set; } // primary key

        public DateTime TransactionDate { get; set; }
        public string UserName { get; set; } // Foreign key
        public ICollection<Product> Products{ get; set; } // All transaction items
        public float TotalCost { get; set; }
        public TransactioinType TransactionType { get; set; } // 0 = purchase 1 = return
        
        
        
        
        
    }
}