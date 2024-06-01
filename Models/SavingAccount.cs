using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework___Code_First.Models
{
    public class SavingAccount
    {
        public int SavingAccountId { get; set; } 
        public int Amount { get; set; } 
        public decimal SavingRate { get; set; }  
               
    }
}
