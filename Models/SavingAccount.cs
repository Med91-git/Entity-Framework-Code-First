using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework___Code_First.Models
{
    public class SavingAccount
    {
        public Guid SavingAccountId { get; set; }
        public int Amount { get; set; } 
        public int SavingRate { get; set; }  
        
    }
}
